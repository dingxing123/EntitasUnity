﻿using System;
using System.Collections.Generic;
using Entitas;
using Entitas.Data;

namespace UnityClient
{
    public class SkillInputSystem : IInitializeSystem
    {
        public SkillInputSystem(Contexts contexts)
        {
        }
        public void Initialize()
        {
            Services.Instance.InputService.ListenKeyboardEvent(Keyboard.Code.H, this.OnKeyboardEvent);
            Services.Instance.InputService.ListenKeyboardEvent(Keyboard.Code.J, this.OnKeyboardEvent);
            Services.Instance.InputService.ListenKeyboardEvent(Keyboard.Code.K, this.OnKeyboardEvent);
            Services.Instance.InputService.ListenKeyboardEvent(Keyboard.Code.L, this.OnKeyboardEvent);
            Services.Instance.InputService.ListenKeyboardEvent(Keyboard.Code.Space, this.OnKeyboardEvent);
        }
        private void OnKeyboardEvent(int keyCode, int what)
        {
            if ((int)Keyboard.Event.Down == what)
            {
                var keybings = Contexts.sharedInstance.input.skillKeyBinding.Value;
                int skillId = 0;
                if (keybings.TryGetValue((Keyboard.Code)keyCode, out skillId))
                {
                    StartSkillWithCategory(keyCode, skillId);
                }
            }
        }
        private void StartSkillWithCategory(int catecory, int headSkillId)
        {
            var mainPlayer = Contexts.sharedInstance.game.mainPlayerEntity;
            if (null != mainPlayer && mainPlayer.hasSkill)
            {
                long curTime = (long)(Contexts.sharedInstance.input.time.Value * 1000);

                int finalSkillId = headSkillId;
                if(null != mainPlayer.skill.Instance && mainPlayer.skill.Instance.Category == catecory)
                {
                    finalSkillId = GetNextSkillId(mainPlayer.skill.Instance.SkillId, headSkillId);
                }
                if(mainPlayer.hasLastSkill && mainPlayer.lastSkill.Category == catecory && curTime < mainPlayer.lastSkill.FinishTime + 1000)
                {
                    finalSkillId = GetNextSkillId(mainPlayer.lastSkill.Id, headSkillId);
                }
                SkillSystem.Instance.StartSkill(mainPlayer, mainPlayer, finalSkillId, catecory, mainPlayer.position.Value, mainPlayer.rotation.Value);
            }
        }
        private int GetNextSkillId(int skillId, int headSkillId)
        {
            SkillConfig config = SkillConfigProvider.Instance.GetSkillConfig(skillId);
            if (null != config && config.NextId > 0)
                return config.NextId;

            return headSkillId;
        }
    }
}