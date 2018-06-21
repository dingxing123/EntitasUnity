﻿using System;
using System.Collections.Generic;

namespace Skill.CommonValues
{
  internal sealed class GreaterThanOperator : ISkillValue<object>
  {
    public void InitFromDsl(ScriptableData.ISyntaxComponent param)
    {
      ScriptableData.CallData callData = param as ScriptableData.CallData;
      if (null != callData && callData.GetId() == ">") {
        if (callData.GetParamNum() == 2) {
          m_X.InitFromDsl(callData.GetParam(0));
          m_Y.InitFromDsl(callData.GetParam(1));
        }
        TryUpdateValue();
      }
    }
    public ISkillValue<object> Clone()
    {
      GreaterThanOperator val = new GreaterThanOperator();
      val.m_X = m_X.Clone();
      val.m_Y = m_Y.Clone();
      val.m_HaveValue = m_HaveValue;
      val.m_Value = m_Value;
      return val;
    }
    public void Evaluate(object iterator, object[] args)
    {
      m_X.Evaluate(iterator, args);
      m_Y.Evaluate(iterator, args);
      TryUpdateValue();
    }
    public void Evaluate(SkillInstance instance)
    {
      m_X.Evaluate(instance);
      m_Y.Evaluate(instance);
      TryUpdateValue();
    }
    public void Analyze(SkillInstance instance)
    {
      m_X.Analyze(instance);
      m_Y.Analyze(instance);
    }
    public bool HaveValue
    {
      get
      {
        return m_HaveValue;
      }
    }
    public object Value
    {
      get
      {
        return m_Value;
      }
    }

    private void TryUpdateValue()
    {
      if (m_X.HaveValue && m_Y.HaveValue) {
        m_HaveValue = true;
        object objX = m_X.Value;
        object objY = m_Y.Value;
        float x = SkillValueHelper.CastTo<float>(objX);
        float y = SkillValueHelper.CastTo<float>(objY);
        m_Value = (x > y ? 1 : 0);
      }
    }

    private ISkillValue<object> m_X = new SkillValue();
    private ISkillValue<object> m_Y = new SkillValue();
    private bool m_HaveValue;
    private object m_Value;
  }
  internal sealed class GreaterEqualThanOperator : ISkillValue<object>
  {
    public void InitFromDsl(ScriptableData.ISyntaxComponent param)
    {
      ScriptableData.CallData callData = param as ScriptableData.CallData;
      if (null != callData && callData.GetId() == ">=") {
        if (callData.GetParamNum() == 2) {
          m_X.InitFromDsl(callData.GetParam(0));
          m_Y.InitFromDsl(callData.GetParam(1));
        }
        TryUpdateValue();
      }
    }
    public ISkillValue<object> Clone()
    {
      GreaterEqualThanOperator val = new GreaterEqualThanOperator();
      val.m_X = m_X.Clone();
      val.m_Y = m_Y.Clone();
      val.m_HaveValue = m_HaveValue;
      val.m_Value = m_Value;
      return val;
    }
    public void Evaluate(object iterator, object[] args)
    {
      m_X.Evaluate(iterator, args);
      m_Y.Evaluate(iterator, args);
      TryUpdateValue();
    }
    public void Evaluate(SkillInstance instance)
    {
      m_X.Evaluate(instance);
      m_Y.Evaluate(instance);
      TryUpdateValue();
    }
    public void Analyze(SkillInstance instance)
    {
      m_X.Analyze(instance);
      m_Y.Analyze(instance);
    }
    public bool HaveValue
    {
      get
      {
        return m_HaveValue;
      }
    }
    public object Value
    {
      get
      {
        return m_Value;
      }
    }

    private void TryUpdateValue()
    {
      if (m_X.HaveValue && m_Y.HaveValue) {
        m_HaveValue = true;
        object objX = m_X.Value;
        object objY = m_Y.Value;
        float x = SkillValueHelper.CastTo<float>(objX);
        float y = SkillValueHelper.CastTo<float>(objY);
        m_Value = (x >= y ? 1 : 0);
      }
    }

    private ISkillValue<object> m_X = new SkillValue();
    private ISkillValue<object> m_Y = new SkillValue();
    private bool m_HaveValue;
    private object m_Value;
  }
  internal sealed class EqualOperator : ISkillValue<object>
  {
    public void InitFromDsl(ScriptableData.ISyntaxComponent param)
    {
      ScriptableData.CallData callData = param as ScriptableData.CallData;
      if (null != callData && callData.GetId() == "==") {
        if (callData.GetParamNum() == 2) {
          m_X.InitFromDsl(callData.GetParam(0));
          m_Y.InitFromDsl(callData.GetParam(1));
        }
        TryUpdateValue();
      }
    }
    public ISkillValue<object> Clone()
    {
      EqualOperator val = new EqualOperator();
      val.m_X = m_X.Clone();
      val.m_Y = m_Y.Clone();
      val.m_HaveValue = m_HaveValue;
      val.m_Value = m_Value;
      return val;
    }
    public void Evaluate(object iterator, object[] args)
    {
      m_X.Evaluate(iterator, args);
      m_Y.Evaluate(iterator, args);
      TryUpdateValue();
    }
    public void Evaluate(SkillInstance instance)
    {
      m_X.Evaluate(instance);
      m_Y.Evaluate(instance);
      TryUpdateValue();
    }
    public void Analyze(SkillInstance instance)
    {
      m_X.Analyze(instance);
      m_Y.Analyze(instance);
    }
    public bool HaveValue
    {
      get
      {
        return m_HaveValue;
      }
    }
    public object Value
    {
      get
      {
        return m_Value;
      }
    }

    private void TryUpdateValue()
    {
      if (m_X.HaveValue && m_Y.HaveValue) {
        m_HaveValue = true;
        object objX = m_X.Value;
        object objY = m_Y.Value;
        if (objX is string || objY is string) {
          string x = SkillValueHelper.CastTo<string>(objX);
          string y = SkillValueHelper.CastTo<string>(objY);
          m_Value = (x == y ? 1 : 0);
        } else {
          int x = (int)Convert.ChangeType(objX, typeof(int));
          int y = (int)Convert.ChangeType(objY, typeof(int));
          m_Value = (x == y ? 1 : 0);
        }
      }
    }

    private ISkillValue<object> m_X = new SkillValue();
    private ISkillValue<object> m_Y = new SkillValue();
    private bool m_HaveValue;
    private object m_Value;
  }
  internal sealed class NotEqualOperator : ISkillValue<object>
  {
    public void InitFromDsl(ScriptableData.ISyntaxComponent param)
    {
      ScriptableData.CallData callData = param as ScriptableData.CallData;
      if (null != callData && callData.GetId() == "!=") {
        if (callData.GetParamNum() == 2) {
          m_X.InitFromDsl(callData.GetParam(0));
          m_Y.InitFromDsl(callData.GetParam(1));
        }
        TryUpdateValue();
      }
    }
    public ISkillValue<object> Clone()
    {
      NotEqualOperator val = new NotEqualOperator();
      val.m_X = m_X.Clone();
      val.m_Y = m_Y.Clone();
      val.m_HaveValue = m_HaveValue;
      val.m_Value = m_Value;
      return val;
    }
    public void Evaluate(object iterator, object[] args)
    {
      m_X.Evaluate(iterator, args);
      m_Y.Evaluate(iterator, args);
      TryUpdateValue();
    }
    public void Evaluate(SkillInstance instance)
    {
      m_X.Evaluate(instance);
      m_Y.Evaluate(instance);
      TryUpdateValue();
    }
    public void Analyze(SkillInstance instance)
    {
      m_X.Analyze(instance);
      m_Y.Analyze(instance);
    }
    public bool HaveValue
    {
      get
      {
        return m_HaveValue;
      }
    }
    public object Value
    {
      get
      {
        return m_Value;
      }
    }

    private void TryUpdateValue()
    {
      if (m_X.HaveValue && m_Y.HaveValue) {
        m_HaveValue = true;
        object objX = m_X.Value;
        object objY = m_Y.Value;
        if (objX is string || objY is string) {
          string x = SkillValueHelper.CastTo<string>(objX);
          string y = SkillValueHelper.CastTo<string>(objY);
          m_Value = (x != y ? 1 : 0);
        } else {
          int x = (int)Convert.ChangeType(objX, typeof(int));
          int y = (int)Convert.ChangeType(objY, typeof(int));
          m_Value = (x != y ? 1 : 0);
        }
      }
    }

    private ISkillValue<object> m_X = new SkillValue();
    private ISkillValue<object> m_Y = new SkillValue();
    private bool m_HaveValue;
    private object m_Value;
  }
  internal sealed class LessThanOperator : ISkillValue<object>
  {
    public void InitFromDsl(ScriptableData.ISyntaxComponent param)
    {
      ScriptableData.CallData callData = param as ScriptableData.CallData;
      if (null != callData && callData.GetId() == "<") {
        if (callData.GetParamNum() == 2) {
          m_X.InitFromDsl(callData.GetParam(0));
          m_Y.InitFromDsl(callData.GetParam(1));
        }
        TryUpdateValue();
      }
    }
    public ISkillValue<object> Clone()
    {
      LessThanOperator val = new LessThanOperator();
      val.m_X = m_X.Clone();
      val.m_Y = m_Y.Clone();
      val.m_HaveValue = m_HaveValue;
      val.m_Value = m_Value;
      return val;
    }
    public void Evaluate(object iterator, object[] args)
    {
      m_X.Evaluate(iterator, args);
      m_Y.Evaluate(iterator, args);
      TryUpdateValue();
    }
    public void Evaluate(SkillInstance instance)
    {
      m_X.Evaluate(instance);
      m_Y.Evaluate(instance);
      TryUpdateValue();
    }
    public void Analyze(SkillInstance instance)
    {
      m_X.Analyze(instance);
      m_Y.Analyze(instance);
    }
    public bool HaveValue
    {
      get
      {
        return m_HaveValue;
      }
    }
    public object Value
    {
      get
      {
        return m_Value;
      }
    }

    private void TryUpdateValue()
    {
      if (m_X.HaveValue && m_Y.HaveValue) {
        m_HaveValue = true;
        object objX = m_X.Value;
        object objY = m_Y.Value;
        float x = SkillValueHelper.CastTo<float>(objX);
        float y = SkillValueHelper.CastTo<float>(objY);
        m_Value = (x < y ? 1 : 0);
      }
    }

    private ISkillValue<object> m_X = new SkillValue();
    private ISkillValue<object> m_Y = new SkillValue();
    private bool m_HaveValue;
    private object m_Value;
  }
  internal sealed class LessEqualThanOperator : ISkillValue<object>
  {
    public void InitFromDsl(ScriptableData.ISyntaxComponent param)
    {
      ScriptableData.CallData callData = param as ScriptableData.CallData;
      if (null != callData && callData.GetId() == "<=") {
        if (callData.GetParamNum() == 2) {
          m_X.InitFromDsl(callData.GetParam(0));
          m_Y.InitFromDsl(callData.GetParam(1));
        }
        TryUpdateValue();
      }
    }
    public ISkillValue<object> Clone()
    {
      LessEqualThanOperator val = new LessEqualThanOperator();
      val.m_X = m_X.Clone();
      val.m_Y = m_Y.Clone();
      val.m_HaveValue = m_HaveValue;
      val.m_Value = m_Value;
      return val;
    }
    public void Evaluate(object iterator, object[] args)
    {
      m_X.Evaluate(iterator, args);
      m_Y.Evaluate(iterator, args);
      TryUpdateValue();
    }
    public void Evaluate(SkillInstance instance)
    {
      m_X.Evaluate(instance);
      m_Y.Evaluate(instance);
      TryUpdateValue();
    }
    public void Analyze(SkillInstance instance)
    {
      m_X.Analyze(instance);
      m_Y.Analyze(instance);
    }
    public bool HaveValue
    {
      get
      {
        return m_HaveValue;
      }
    }
    public object Value
    {
      get
      {
        return m_Value;
      }
    }

    private void TryUpdateValue()
    {
      if (m_X.HaveValue && m_Y.HaveValue) {
        m_HaveValue = true;
        object objX = m_X.Value;
        object objY = m_Y.Value;
        float x = SkillValueHelper.CastTo<float>(objX);
        float y = SkillValueHelper.CastTo<float>(objY);
        m_Value = (x <= y ? 1 : 0);
      }
    }

    private ISkillValue<object> m_X = new SkillValue();
    private ISkillValue<object> m_Y = new SkillValue();
    private bool m_HaveValue;
    private object m_Value;
  }
  internal sealed class IsNullOperator : ISkillValue<object>
  {
    public void InitFromDsl(ScriptableData.ISyntaxComponent param)
    {
      ScriptableData.CallData callData = param as ScriptableData.CallData;
      if (null != callData && callData.GetId() == "isnull") {
        if (callData.GetParamNum() == 1) {
          m_X.InitFromDsl(callData.GetParam(0));
        }
        TryUpdateValue();
      }
    }
    public ISkillValue<object> Clone()
    {
      IsNullOperator val = new IsNullOperator();
      val.m_X = m_X.Clone();
      val.m_HaveValue = m_HaveValue;
      val.m_Value = m_Value;
      return val;
    }
    public void Evaluate(object iterator, object[] args)
    {
      m_X.Evaluate(iterator, args);
      TryUpdateValue();
    }
    public void Evaluate(SkillInstance instance)
    {
      m_X.Evaluate(instance);
      TryUpdateValue();
    }
    public void Analyze(SkillInstance instance)
    {
      m_X.Analyze(instance);
    }
    public bool HaveValue
    {
      get
      {
        return m_HaveValue;
      }
    }
    public object Value
    {
      get
      {
        return m_Value;
      }
    }

    private void TryUpdateValue()
    {
      m_HaveValue = true;
      if (m_X.HaveValue) {
        object objX = m_X.Value;
        m_Value = (null == objX);
      } else {
        m_Value = true;
      }
    }

    private ISkillValue<object> m_X = new SkillValue();
    private bool m_HaveValue;
    private object m_Value;
  }
}
