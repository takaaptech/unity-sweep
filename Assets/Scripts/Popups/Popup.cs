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
namespace Mempic.Application.Popups {
  public class Popup : Mempic.Popups.Popup {

    /**
     *
     *
     *
     */
    [Header("Popup references")]
    public Controller controller;

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
