using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace LuaFramework {
    public class SoundManager : Manager {
        private AudioSource audio;
        private Hashtable sounds = new Hashtable();
        string backSoundKey;
        void Start() {
            audio = GetComponent<AudioSource>();
            if (audio==null)
            {
                gameObject.AddComponent<AudioSource>();
            }
        }
        //回调函数原型
        private delegate void GetBack(AudioClip clip, string key);
        
        //获取声音资源
        private void Get(string abName,string assetName, GetBack cb)
        {
            string key = abName + "." + assetName;
            if (sounds[key]==null)//表中没有,ab中实例化
            {
                ResManager.LoadAudioClip(abName, assetName, delegate(Object[] objs)//这里的委托参数是lua传过来的
                  {
                      if (objs == null || objs[0] == null)
                      {
                          Debug.Log("PlaySound fail");
                          cb(null, key);
                          return;
                      }
                      else
                      {
                          sounds.Add(key, objs[0]);
                          cb(objs[0] as AudioClip, key);
                          return;
                      }
                  }
                );
            }
            else
            {
                cb(sounds[key] as AudioClip, key);
            }
        }
        //播放背景音乐
        public void PlayBackSound(string abName,string assetName)
        {
            backSoundKey = abName + "." + assetName;
            print(backSoundKey);
            Get(abName, assetName, GetCallBack);
        }
        //播放背景音乐的回调
        public void GetCallBack(AudioClip clip, string key)
        {
            if (clip==null)
            {
                return;
            }
            if (key!=backSoundKey)
            {
                return;
            }
            audio.loop = true;
            audio.clip = clip;
            audio.Play();
        }
        //停止播放背景音乐
        public void StopBackSound()
        {
            backSoundKey = "";
            audio.Stop();
        }
        //播放音效
        public void PlaySound(string abName,string assetName)
        {
            Debugger.Log("123");
            Get(abName, assetName, GetSoundCallBack);
        }
        //播放音效的回调方法
        public void GetSoundCallBack(AudioClip clip,string key)
        {
            if (clip==null)
            {
                Debugger.Log("加载声音失败");
                return;
            }
            if (Camera.main==null)
            {
                Debugger.Log("相机为空");
                return;
            }
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
        }
        /// <summary>
        /// 添加一个声音
        /// </summary>
        void Add(string key, AudioClip value) {
            if (sounds[key] != null || value == null) return;
            sounds.Add(key, value);
        }

        /// <summary>
        /// 获取一个声音
        /// </summary>
        AudioClip Get(string key) {
            if (sounds[key] == null) return null;
            return sounds[key] as AudioClip;
        }

        /// <summary>
        /// 载入一个音频
        /// </summary>
        public AudioClip LoadAudioClip(string path) {
            AudioClip ac = Get(path);
            if (ac == null) {
                ac = (AudioClip)Resources.Load(path, typeof(AudioClip));
                Add(path, ac);
            }
            return ac;
        }

        /// <summary>
        /// 是否播放背景音乐，默认是1：播放
        /// </summary>
        /// <returns></returns>
        public bool CanPlayBackSound() {
            string key = AppConst.AppPrefix + "BackSound";
            int i = PlayerPrefs.GetInt(key, 1);
            return i == 1;
        }

        /// <summary>
        /// 播放背景音乐
        /// </summary>
        /// <param name="canPlay"></param>
        public void PlayBacksound(string name, bool canPlay) {
            if (audio.clip != null) {
                if (name.IndexOf(audio.clip.name) > -1) {
                    if (!canPlay) {
                        audio.Stop();
                        audio.clip = null;
                        Util.ClearMemory();
                    }
                    return;
                }
            }
            if (canPlay) {
                audio.loop = true;
                audio.clip = LoadAudioClip(name);
                audio.Play();
            } else {
                audio.Stop();
                audio.clip = null;
                Util.ClearMemory();
            }
        }

        /// <summary>
        /// 是否播放音效,默认是1：播放
        /// </summary>
        /// <returns></returns>
        public bool CanPlaySoundEffect() {
            string key = AppConst.AppPrefix + "SoundEffect";
            int i = PlayerPrefs.GetInt(key, 1);
            return i == 1;
        }

        /// <summary>
        /// 播放音频剪辑
        /// </summary>
        /// <param name="clip"></param>
        /// <param name="position"></param>
        public void Play(AudioClip clip, Vector3 position) {
            if (!CanPlaySoundEffect()) return;
            AudioSource.PlayClipAtPoint(clip, position); 
        }
    }
}