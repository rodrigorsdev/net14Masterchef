﻿using Masterchef.Application.Ingrediente.Interface;
using Masterchef.Core.Application.Interface;
using Masterchef.Core.Application.Vo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Masterchef.Web.Controllers
{
    [Authorize]
    public class IngredienteController : BaseController
    {
        private readonly IIngredienteService _ingredienteService;

        public IngredienteController(
            INotificationHandler<Notification> notifications,
            IIngredienteService ingredienteService) : base(notifications)
        {
            _ingredienteService = ingredienteService;
        }

        [ValidateAntiForgeryToken, HttpPost]
        public JsonResult Add(Application.Ingrediente.ViewModel.AddIngrediente vmodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _ingredienteService.Add(vmodel);

                    if (ValidOperation())
                        return Json(new { result = true, list = _ingredienteService.List(), message = "Inserido com sucesso!" });
                }
            }
            catch (Exception e)
            {
            }

            AddMessages();

            return Json(new { result = false, list = "", message = "Erro ao inserir!" });
        }
    }
}