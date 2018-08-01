﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entitas;
using Util;

namespace UnityClient.Kernel
{
    internal class LogicMoudle : IActionQueue
    {

        private GameLogicSystems m_GameLogicSystems;
        private GameViewSystems m_GameViewSystems;

        private GameStateSystems m_GameStateSystems;

        private InputSystems m_InputSystems;

        public void OnStart()
        {
            var contexts = Contexts.sharedInstance;

            m_InputSystems = new InputSystems(contexts, Services.Instance);
            m_InputSystems.Initialize();

            m_GameStateSystems = new GameStateSystems(contexts, Services.Instance);
            m_GameStateSystems.Initialize();

            m_GameLogicSystems = new GameLogicSystems(contexts, Services.Instance);
            m_GameLogicSystems.Initialize();

            m_GameViewSystems = new GameViewSystems(contexts, Services.Instance);
            m_GameViewSystems.Initialize();



            LogUtil.Info("Game Start ...");
        }
        public void Update()
        {
            m_InputSystems.Execute();
            m_InputSystems.Cleanup();

            m_GameStateSystems.Execute();
            m_GameStateSystems.Cleanup();

            m_GameLogicSystems.Execute();
            m_GameLogicSystems.Cleanup();

            m_ActionQueue.HandleActions(m_ActionNumPerTick);
        }
        public void FixedUpdate()
        {
            m_GameViewSystems.Execute();
            m_GameViewSystems.Cleanup();
        }
        public void OnQuit()
        {
            m_InputSystems.Execute();
            m_InputSystems.Cleanup();

            m_GameLogicSystems.ClearReactiveSystems();
            m_GameLogicSystems.TearDown();

            m_GameViewSystems.ClearReactiveSystems();
            m_GameViewSystems.TearDown();

            m_GameStateSystems.ClearReactiveSystems();
            m_GameStateSystems.TearDown();


            Contexts.sharedInstance.Reset();
        }
        public int CurActionNum
        {
            get
            {
                return m_ActionQueue.CurActionNum;
            }
        }
        public void QueueActionWithDelegation(Delegate action, params object[] args)
        {
            m_ActionQueue.QueueActionWithDelegation(action, args);
        }

        public void QueueAction(MyAction action)
        {
            m_ActionQueue.QueueAction(action);
        }

        public void QueueAction<T1>(MyAction<T1> action, T1 t1)
        {
            m_ActionQueue.QueueAction(action, t1);
        }

        public void QueueAction<T1, T2>(MyAction<T1, T2> action, T1 t1, T2 t2)
        {
            m_ActionQueue.QueueAction(action, t1, t2);
        }

        public void QueueAction<T1, T2, T3>(MyAction<T1, T2, T3> action, T1 t1, T2 t2, T3 t3)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3);
        }

        public void QueueAction<T1, T2, T3, T4>(MyAction<T1, T2, T3, T4> action, T1 t1, T2 t2, T3 t3, T4 t4)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4);
        }

        public void QueueAction<T1, T2, T3, T4, T5>(MyAction<T1, T2, T3, T4, T5> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6>(MyAction<T1, T2, T3, T4, T5, T6> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7>(MyAction<T1, T2, T3, T4, T5, T6, T7> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8>(MyAction<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
        }

        public void QueueAction<R>(MyFunc<R> action)
        {
            m_ActionQueue.QueueAction(action);
        }

        public void QueueAction<T1, R>(MyFunc<T1, R> action, T1 t1)
        {
            m_ActionQueue.QueueAction(action, t1);
        }

        public void QueueAction<T1, T2, R>(MyFunc<T1, T2, R> action, T1 t1, T2 t2)
        {
            m_ActionQueue.QueueAction(action, t1, t2);
        }

        public void QueueAction<T1, T2, T3, R>(MyFunc<T1, T2, T3, R> action, T1 t1, T2 t2, T3 t3)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3);
        }

        public void QueueAction<T1, T2, T3, T4, R>(MyFunc<T1, T2, T3, T4, R> action, T1 t1, T2 t2, T3 t3, T4 t4)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4);
        }

        public void QueueAction<T1, T2, T3, T4, T5, R>(MyFunc<T1, T2, T3, T4, T5, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, R>(MyFunc<T1, T2, T3, T4, T5, T6, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, T8, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
        }

        public void QueueAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, R>(MyFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, R> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            m_ActionQueue.QueueAction(action, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
        }

        private const int m_ActionNumPerTick = 1024;

        private ClientAsyncActionProcessor m_ActionQueue = new ClientAsyncActionProcessor();
    }
}
