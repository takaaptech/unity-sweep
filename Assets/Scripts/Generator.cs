/**
 *
 * @name mempic.org
 * @copyright (c) by SWISS INTERGROUP LP
 * @copyright (c) by WWW.MEMPIC.ORG
 * @copyright (c) by IGOR MATS
 *
 *
 * @license http://www.mempic.org/licenses/private
 *
 * By exercising the licensed rights you accept and agree to be bound by the
 * terms and conditions of this @license. To the extent this @license
 * may be interpreted as a contract, you are granted the licensed rights
 * in consideration of your acceptance of these terms and conditions,
 * and the licensor grants you such rights in consideration of benefits
 * the licensor receives from making the licensed material available
 * under these terms and conditions.
 *
 */
using Mempic;
using Mempic.Entities;
using Mempic.Application;
using Mempic.Application.Entities;
using Mempic.Application.Screens;

using UnityEngine;

using System;
using System.Collections.Generic;

using DG.Tweening;

/**
 *
 *
 *
 */
using Math = Mempic.Math;

/**
 *
 *
 *
 */
namespace Mempic.Application {

  /**
   *
   *
   *
   */
  public class Generator : Entity {

    /**
     *
     *
     *
     */
    public virtual void OnMenu()
    {
    }

    public virtual void OnGame()
    {
    }

    public virtual void OnFinish()
    {
    }

    public virtual void OnRevive()
    {
    }

    public virtual void OnStore()
    {
    }

    public virtual void OnRent()
    {
    }

    public virtual void OnMore()
    {
    }

    public virtual void OnWheel()
    {
    }

    public virtual void OnCapture()
    {
    }

    /**
     *
     *
     *
     */
    protected virtual void Reset()
    {
    }

    /**
     *
     *
     *
     */
    public virtual void UpdateMenu()
    {
    }

    public virtual void UpdateGame()
    {
    }

    public virtual void UpdateFinish()
    {
    }

    public virtual void UpdateRevive()
    {
    }

    public virtual void UpdateStore()
    {
    }

    public virtual void UpdateRent()
    {
    }

    public virtual void UpdateMore()
    {
    }

    public virtual void UpdateWheel()
    {
    }

    public virtual void UpdateCapture()
    {
    }
  }
}

