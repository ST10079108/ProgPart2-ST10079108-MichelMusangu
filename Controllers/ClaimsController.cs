using ClaimsPortal.Data;
using ClaimsPortal.Models;
using ClaimsPortal.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClaimsPortal.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ClaimsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddClaimModel claimModel)
        {
            var claim = new Claim
            {
                Id = claimModel.Id,
                Name = claimModel.Name,
                Description = claimModel.Description,
                HoursWorked = claimModel.Hours,
                Rate = claimModel.Rate,
                Total = claimModel.Total,
                Status = claimModel.Status,
            };

            await dbContext.Claims.AddAsync(claim);
            await dbContext.SaveChangesAsync();



            //return View();
            return RedirectToAction("ListClaims");
        }

        

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var claims = await dbContext.Claims.ToListAsync();

            return View(claims);
        }

        [HttpGet]
        public async Task<IActionResult> Approve(int id)
        {
            var claim = await dbContext.Claims.FindAsync(id);

            if (claim != null)
            {
                claim.Status = "Approved";
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("ListClaims");
        }

        [HttpGet]
        public async Task<IActionResult> Reject(int id)
        {
            var claim = await dbContext.Claims.FindAsync(id);

            if (claim != null)
            {
                claim.Status = "Rejected";
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("ListClaims");
        }


        public IActionResult ListClaims()
        {
            var claims = dbContext.Claims.ToList();
            return View(claims);
        }
    }
}
 