﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spiderman",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new artist[]
                {
                    new artist() { Name = "Dan Slott", Role = "Script:"},
                    new artist() { Name = "Humberto Ramos", Role = "Pencils"},
                    new artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new artist() { Name = "Edgar Delgado", Role = "Colors"},
                    new artist() { Name = "Chris Eliopoulos", Role = "Letters"},
                }
            };

            return View(comicBook);

        }

    }
}