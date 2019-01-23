﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
		// this will be called when we go to GET: Movies/Random
        public ActionResult Random()
        {

	        var movie = new Movie()
	        {
		        Name = "Shrek!"
	        };

            return View(movie); // add movie model to render it
        }
    }
}