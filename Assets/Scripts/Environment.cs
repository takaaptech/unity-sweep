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
using Mempic.Post;
using Mempic.Entities;
using Mempic.Platform;
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

/**`
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
  public class Environment : Entity {

    /**
     *
     *
     *
     */
    public virtual void OnMenu()
    {
      Mempic.Platform.Ad.OnMenu();

      /**
       *
       *
       *
       */
      this.controller.generator.OnMenu();
      this.controller.control.OnMenu();
      this.controller.counter.OnMenu();
    }

    public virtual void OnGame()
    {
      Mempic.Platform.Ad.OnGame();

      /**
       *
       *
       *
       */
      this.controller.generator.OnGame();
      this.controller.control.OnGame();
      this.controller.counter.OnGame();
    }

    public virtual void OnFinish()
    {
      Mempic.Platform.Ad.OnFinish(
        delegate(bool state) {

        /**
         *
         *
         *
         */
        this.controller.generator.OnFinish();
        this.controller.control.OnFinish();
        this.controller.counter.OnFinish();
        }
      );
    }

    public virtual void OnRevive()
    {
      this.controller.generator.OnRevive();
      this.controller.control.OnRevive();
      this.controller.counter.OnRevive();
    }

    public virtual void OnStore()
    {
      this.controller.generator.OnStore();
      this.controller.control.OnStore();
      this.controller.counter.OnStore();
    }

    public virtual void OnRent()
    {
      this.controller.generator.OnRent();
      this.controller.control.OnRent();
      this.controller.counter.OnRent();
    }

    public virtual void OnMore()
    {
      this.controller.generator.OnMore();
      this.controller.control.OnMore();
      this.controller.counter.OnMore();
    }

    public virtual void OnWheel()
    {
      this.controller.generator.OnWheel();
      this.controller.control.OnWheel();
      this.controller.counter.OnWheel();
    }

    public virtual void OnCapture()
    {
      this.controller.generator.OnCapture();
      this.controller.control.OnCapture();
      this.controller.counter.OnCapture();
    }

    /**
     *
     *
     *
     */
    public virtual void Reset()
    {
      this.controller.Reset();
    }

    /**
     *
     *
     *
     */
    public virtual void UpdateMenu()
    {
      this.controller.generator.UpdateMenu();
      this.controller.control.UpdateMenu();
      this.controller.counter.UpdateMenu();
    }

    public virtual void UpdateGame()
    {
      this.controller.generator.UpdateGame();
      this.controller.control.UpdateGame();
      this.controller.counter.UpdateGame();
    }

    public virtual void UpdateFinish()
    {
      this.controller.generator.UpdateFinish();
      this.controller.control.UpdateFinish();
      this.controller.counter.UpdateFinish();
    }

    public virtual void UpdateRevive()
    {
      this.controller.generator.UpdateRevive();
      this.controller.control.UpdateRevive();
      this.controller.counter.UpdateRevive();
    }

    public virtual void UpdateStore()
    {
      this.controller.generator.UpdateStore();
      this.controller.control.UpdateStore();
      this.controller.counter.UpdateStore();
    }

    public virtual void UpdateRent()
    {
      this.controller.generator.UpdateRent();
      this.controller.control.UpdateRent();
      this.controller.counter.UpdateRent();
    }

    public virtual void UpdateMore()
    {
      this.controller.generator.UpdateMore();
      this.controller.control.UpdateMore();
      this.controller.counter.UpdateMore();
    }

    public virtual void UpdateWheel()
    {
      this.controller.generator.UpdateWheel();
      this.controller.control.UpdateWheel();
      this.controller.counter.UpdateWheel();
    }

    public virtual void UpdateCapture()
    {
      this.controller.generator.UpdateCapture();
      this.controller.control.UpdateCapture();
      this.controller.counter.UpdateCapture();
    }
  }
}

