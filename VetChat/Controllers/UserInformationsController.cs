using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using VetChat.Data;

namespace VetChat.Controllers
{
    public class UserInformationsController : Controller
    {
        private readonly VetChatContext _context;

        public UserInformationsController(VetChatContext context)
        {
            _context = context;
        }

        // GET: UserInformations
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserInformation.ToListAsync());
        }

        // GET: UserInformations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInformation = await _context.UserInformation
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userInformation == null)
            {
                return NotFound();
            }

            return View(userInformation);
        }

        // GET: UserInformations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Username,Password,ConfirmPassword,Firstname,Lastname,Contact,Branch,DateOfEntry,Ets")] UserInformation userInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userInformation);
        }

        // GET: UserInformations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInformation = await _context.UserInformation.FindAsync(id);
            if (userInformation == null)
            {
                return NotFound();
            }
            return View(userInformation);
        }

        // POST: UserInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Username,Password,ConfirmPassword,Firstname,Lastname,Contact,Branch,DateOfEntry,Ets")] UserInformation userInformation)
        {
            if (id != userInformation.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserInformationExists(userInformation.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userInformation);
        }

        // GET: UserInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInformation = await _context.UserInformation
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userInformation == null)
            {
                return NotFound();
            }

            return View(userInformation);
        }

        // POST: UserInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userInformation = await _context.UserInformation.FindAsync(id);
            _context.UserInformation.Remove(userInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserInformationExists(int id)
        {
            return _context.UserInformation.Any(e => e.UserId == id);
        }
    }
}