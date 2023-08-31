using Endpoint.Site.Models;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Data;
using System.Diagnostics;
using test50.Domain.Commons.Validators;
using test50.Domain.Entities.Users;

namespace Endpoint.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IValidator<Roles> _validatorRole;
        private readonly IValidator<Address> _validatorAddress;
        public HomeController(IValidator<Roles> validatorRole, IValidator<Address> validatorAddress)
        {
            _validatorRole = validatorRole;
            _validatorAddress = validatorAddress;
        }
        ///////////////////// USER
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Users users)
        {
            return View();
        }

        ////////////////// ROLE
        // this library: https://www.nuget.org/packages/FluentValidation#versions-body-tab
        // is enough and it is not necessary to use [FluentValidation.AspNetCore]
        // because in some tutorial videos they used! but that library is outdated!
        [HttpGet]
        public IActionResult Role()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Role(Roles roles)
        {
            ValidationResult result = _validatorRole.Validate(roles);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View(roles);
            }
            return View();
        }

        ///////////////////// Address
        [HttpGet]
        public IActionResult Address()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Address(Address address)
        {
            ValidationResult result = _validatorAddress.Validate(address);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View(address);
            }
            return View();
        }
    }
    public static class Extensions
    {
        public static void AddToModelState(this ValidationResult result, ModelStateDictionary modelState)
        {
            foreach (var error in result.Errors)
            {
                modelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }
    }
}