using Microsoft.AspNetCore.Mvc;

namespace MpEsb.Controllers
{
    public class RecruitmentController : Controller
    {
        public IActionResult CandidateRegistration()
        {
            ViewData["Title"] = "Candidate Registration & Applications";
            return View();
        }

        public IActionResult JobManagement()
        {
            ViewData["Title"] = "Job Posting & Vacancy Management";
            return View();
        }

        public IActionResult Evaluation()
        {
            ViewData["Title"] = "Candidate Evaluation & Screening";
            return View();
        }

        public IActionResult Selection()
        {
            ViewData["Title"] = "Selection & Smart Contract";
            return View();
        }

        public IActionResult SecurityCompliance()
        {
            ViewData["Title"] = "Security, Compliance & Audit";
            return View();
        }

        public IActionResult ReportingAnalytics()
        {
            ViewData["Title"] = "Reporting & Analytics";
            return View();
        }

        public IActionResult AdditionalFeatures()
        {
            ViewData["Title"] = "Additional Features";
            return View();
        }


        public IActionResult login()
        {
           
            return View();
        }
    }
}