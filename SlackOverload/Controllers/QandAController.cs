using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SlackOverload.Models;
using Microsoft.AspNetCore.Http;

namespace SlackOverload.Controllers
{
    public class QandAController : Controller
    {
        private DAL dal;

        public QandAController(IConfiguration config)
        {
            dal = new DAL(config.GetConnectionString("default"));
        }

        public IActionResult Index()
        {
            //get the most recent questions
            IEnumerable<Question> results = dal.GetQuestionsMostRecent();

            ViewData["Questions"] = results;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Question());
        }

        [HttpPost]
        public IActionResult Add(Question q)
        {
            int result = dal.CreateQuestion(q);
            

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddAnswer(int id)
        {
            ViewData["QuestionId"] = id;
            return View(new Answer());
        }

        [HttpPost]
        public IActionResult AddAnswer(Answer q)
        {
            int result = dal.CreateAnswer(q);


            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id) {
            //first get the question detail
            Question question = dal.GetQuestionById(id);

            //then get the relevant answers
            IEnumerable<Answer> answers = dal.GetAnswersByQuestionId(id);

            ViewData["Answers"] = answers;

            return View(question);
        }

        [HttpGet]
        public IActionResult EditAnswer(int id)
        {
            Answer prod = dal.GetAnswerById(id);

            if (prod == null)
            {
                return View("NoSuchItem");
            }
            else
            {
                return View(prod);
            }
        }

        [HttpPost]
        public IActionResult EditAnswer(Answer prod)
        {
            //check the model for validity

            int result = dal.UpdateAnswerById(prod);

            if (result == 1)
            {
                TempData["UserMsg"] = "Item successfully updated";
            }
            else
            {
                TempData["UserMsg"] = "Item not updated";
            }

            //don't always have to return a view
            //this will hand things off to the Index action
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditQuestion(int id)
        {
            Question prod = dal.GetQuestionById(id);

            if (prod == null)
            {
                return View("NoSuchItem");
            }
            else
            {
                return View(prod);
            }
        }

        [HttpPost]
        public IActionResult EditQuestion(Question prod)
        {
            //check the model for validity

            int result = dal.UpdateQuestionById(prod);

            if (result == 1)
            {
                TempData["UserMsg"] = "Item successfully updated";
            }
            else
            {
                TempData["UserMsg"] = "Item not updated";
            }

            //don't always have to return a view
            //this will hand things off to the Index action
            return RedirectToAction("Index");
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Question> results = dal.GetSearchResults(search);
            ViewData["Results"] = results; 

            return View();
        }

        public IActionResult DeleteAnswer(int id)
        {
            dal.DeleteAnswer(id);
                        
            return RedirectToAction("Index");
        }
    }
}