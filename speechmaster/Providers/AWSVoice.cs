﻿using Amazon.Polly.Model;

namespace speechmaster.Providers
{
    public class AWSVoice : IVoice
  {
    private readonly Voice voice;

    public AWSVoice(Voice voice)
    {
      this.voice = voice;
    }

    public string Id => voice.Id;
    public string Name => voice.Name;
    public string Language => voice.LanguageName;
  }
}



