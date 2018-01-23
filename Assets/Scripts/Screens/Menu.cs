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

/**
 *
 *
 *
 */
namespace Mempic.Application.Screens {
  public class Menu : Screen {

    /**
     *
     *
     *
     */
    [Serializable]
    public struct Buttons {
    }

    /**
     *
     *
     *
     */
    [Serializable]
    public struct Texts {
    }

    /**
     *
     *
     *
     */
    [Header("Menu references")]
    public Buttons buttons;
    public Texts texts;

    /**
     *
     *
     *
     */
    public override void OnShow()
    {
      base.OnShow();
    }

    public override void OnHide()
    {
      base.OnHide();
    }

    /**
     *
     *
     *
     */
    public override bool CustomShow()
    {
      return false;
    }

    public override bool CustomHide()
    {
      return false;
    }
  }
}
