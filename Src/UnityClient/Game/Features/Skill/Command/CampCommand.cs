﻿using System;
using ScriptableSystem;
using ScriptableData;

namespace SkillCommands
{
    internal class CampCommand : AbstractCommand
    {
        protected override void Load(CallData callData)
        {
            int num = callData.GetParamNum();
            if(num > 0)
            {
                m_EntityId.InitFromDsl(callData.GetParam(0));
                m_CampId.InitFromDsl(callData.GetParam(1));
            }
        }
        protected override void UpdateArguments(object iterator, object[] args)
        {
            m_CampId.Evaluate(iterator, args);
            m_EntityId.Evaluate(iterator, args);
        }
        protected override void UpdateVariables(Instance instance)
        {
            m_CampId.Evaluate(instance);
            m_EntityId.Evaluate(instance);
        }
        protected override ExecResult ExecCommand(Instance instance, long delta)
        {
            GameEntity target = instance.Target as GameEntity;
            if (null == target)
                return ExecResult.Finished;
            GameEntity entity = Contexts.sharedInstance.game.GetEntityWithId(m_EntityId.Value);
            if (null == entity)
                return ExecResult.Finished;

            entity.ReplaceCamp(m_CampId.Value);
            if(entity.hasAI)
            {
                if (entity.aI.Agent is CharacterAgent agent)
                {
                    agent._set_m_CurTargetId(0);
                }
            }

            return ExecResult.Finished;
        }

        private IValue<uint> m_EntityId = new SkillValue<uint>();
        private IValue<int> m_CampId = new SkillValue<int>();
    }
}
