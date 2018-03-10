﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace DynamicProject.BusinesService
{
    [Route("api/[controller]")]
    public class DynamicController<T>  : Controller where T:BaseViewModel, new()
    {
        [HttpGet]
        public IEnumerable<T> Get()=> new List<T>
        {
            //TODO: Call Business Logic
            new T()  
        };

        [HttpPost]
        public bool Create([FromBody] T input)
        {
            //....
            return true;
        }

    }
}