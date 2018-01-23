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
using Mempic.Application.Popups;

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
  public class Controller : Entity {

    /**
     *
     *
     *
     */
    [Serializable]
    public class Screens
    {
      public Mempic.Application.Screens.Menu menu;
      public Mempic.Application.Screens.Game game;
      public Mempic.Application.Screens.Finish finish;
      public Mempic.Application.Screens.Revive revive;
      public Mempic.Application.Screens.Store store;
      public Mempic.Application.Screens.Rent rent;
      public Mempic.Application.Screens.More more;
      public Mempic.Application.Screens.Wheel wheel;
      public Mempic.Application.Screens.Capture capture;
    }

    /**
     *
     *
     *
     */
    [Serializable]
    public class Popups
    {
      public Mempic.Application.Popups.Promotion promotion;
      public Mempic.Application.Popups.Missions missions;
    }

    /**
     *
     *
     *
     */
    [Serializable]
    public class Cameras
    {
      public Node main;
      public Node ui;
    }

    /**
     *
     *
     *
     */
    [Header("Controller references")]
    public Cameras cameras;
    public Control control;
    public Counter counter;
    public Generator generator;
    public Environment environment;
    //public Character character;
    public Elements elements;
    public Screens screens;
    public Popups popups;

    /**
     *
     *
     *
     */
    public enum State
    {
      NONE,
      MENU,
      GAME,
      FINISH,
      REVIVE,
      STORE,
      RENT,
      MORE,
      WHEEL,
      CAPTURE
    };

    [HideInInspector] public State state = State.NONE;
    [HideInInspector] public State p = State.NONE;

    /**
     *
     *
     *
     */
    protected override void OnStart()
    {
      base.OnStart();

      /**
       *
       *
       *
       */
      this.Sequence(
        this.Delay(0.1),
        this.Finish(
          delegate {
            this.ChangeState(State.MENU);
          }
        )
      );
    }

    /**
     *
     *
     *
     */
    private void OnMenu(int parameter)
    {
      this.environment.OnMenu();
    }

    private void OnGame(int parameter)
    {
      this.environment.OnGame();
    }

    private void OnFinish(int parameter)
    {
      this.environment.OnFinish();
    }

    private void OnRevive(int parameter)
    {
      this.environment.OnRevive();
    }

    private void OnStore(int parameter)
    {
      this.environment.OnStore();
    }

    private void OnRent(int parameter)
    {
      this.environment.OnRent();
    }

    private void OnMore(int parameter)
    {
      this.environment.OnMore();
    }

    private void OnWheel(int parameter)
    {
      this.environment.OnWheel();
    }

    private void OnCapture(int parameter)
    {
      this.environment.OnCapture();
    }

    /**
     *
     *
     *
     */
    // TODO: refactoring;
    public virtual Bounds GetCameraBounds()
    {
      var screenAspect = (float) UnityEngine.Screen.width / (float) UnityEngine.Screen.height;
      var cameraHeight = this.cameras.main.GetComponent<Camera>().orthographicSize * 2;
      var bounds = new Bounds(new Vector3(0, 0, 0), new Vector3(cameraHeight * screenAspect, cameraHeight, 0));

      return bounds;
    }

    /**
     *
     *
     *
     */
    public virtual Vector2 GetBoundsMax()
    {
      return new Vector2(
        this.GetCameraBounds().max.x,
        this.GetCameraBounds().max.y
      );
    }

    public virtual Vector2 GetBoundsMin()
    {
      return new Vector2(
        this.GetCameraBounds().min.x,
        this.GetCameraBounds().min.y
      );
    }

    /**
     *
     *
     *
     */
    public virtual float GetWidth()
    {
      return UnityEngine.Screen.width;
    }

    public virtual float GetHeight()
    {
      return UnityEngine.Screen.height;
    }

    /**
     *
     *
     *
     */
    public virtual Vector2 GetMousePosition()
    {
      return Input.mousePosition;
    }

    /**
     *
     *
     *
     */
    public virtual bool GetMouseState()
    {
      return Input.GetMouseButton(0);
    }

    /**
     *
     *
     *
     */
    public virtual void Reset()
    {
      this.elements.Clear();
    }

    /**
     *
     *
     *
     */
    public virtual void ChangeState(State state = 0, int parameter = 0)
    {
      if(state == 0)
      {
        state = this.p;
      }

      /**
       *
       *
       *
       */
      if(this.state != state)
      {
        this.p = this.state;

        /**
         *
         *
         *
         */
        this.state = state;

        /**
         *
         *
         *
         */
        switch(this.state)
        {
          case State.MENU:
          this.OnMenu(parameter);
          break;
          case State.GAME:
          this.OnGame(parameter);
          break;
          case State.FINISH:
          this.OnFinish(parameter);
          break;
          case State.REVIVE:
          this.OnRevive(parameter);
          break;
          case State.STORE:
          this.OnStore(parameter);
          break;
          case State.RENT:
          this.OnRent(parameter);
          break;
          case State.MORE:
          this.OnMore(parameter);
          break;
          case State.WHEEL:
          this.OnWheel(parameter);
          break;
          case State.CAPTURE:
          this.OnCapture(parameter);
          break;
        }
      }
    }

    /**
     *
     *
     *
     */
    private void UpdateMenu()
    {
      this.environment.UpdateMenu();
    }

    private void UpdateGame()
    {
      this.environment.UpdateGame();
    }

    private void UpdateFinish()
    {
      this.environment.UpdateFinish();
    }

    private void UpdateRevive()
    {
      this.environment.UpdateRevive();
    }

    private void UpdateStore()
    {
      this.environment.UpdateStore();
    }

    private void UpdateRent()
    {
      this.environment.UpdateRent();
    }

    private void UpdateMore()
    {
      this.environment.UpdateMore();
    }

    private void UpdateWheel()
    {
      this.environment.UpdateWheel();
    }

    private void UpdateCapture()
    {
      this.environment.UpdateCapture();
    }

    /**
     *
     *
     *
     */
    private void UpdateStates()
    {
      switch(this.state)
      {
        case State.MENU:
        this.UpdateMenu();
        break;
        case State.GAME:
        this.UpdateGame();
        break;
        case State.FINISH:
        this.UpdateFinish();
        break;
        case State.REVIVE:
        this.UpdateRevive();
        break;
        case State.STORE:
        this.UpdateStore();
        break;
        case State.RENT:
        this.UpdateRent();
        break;
        case State.MORE:
        this.UpdateMore();
        break;
        case State.WHEEL:
        this.UpdateWheel();
        break;
        case State.CAPTURE:
        this.UpdateCapture();
        break;
      }
    }

    /**
     *
     *
     *
     */
    protected override void Update()
    {
      this.UpdateStates();
    }
  }
}
