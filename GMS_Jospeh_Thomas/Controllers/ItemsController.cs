
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GMS_Jospeh_Thomas.Models;
using GMS_Jospeh_Thomas.Data;

public class ItemsController : Controller
{
    private readonly AppDbContext _context;

    public ItemsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: ITEMS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.ItemInfos.ToListAsync());
    }

    // GET: ITEMS/Details/5
    public async Task<IActionResult> Details(int? itemid)
    {
        if (itemid == null)
        {
            return NotFound();
        }

        var item = await _context.ItemInfos
            .FirstOrDefaultAsync(m => m.ItemId == itemid);
        if (item == null)
        {
            return NotFound();
        }

        return View(item);
    }

    // GET: ITEMS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ITEMS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ItemId,Name,Category,PurchaseDate,Quantity,Price")] Item item)
    {
        if (ModelState.IsValid)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(item);
    }

    // GET: ITEMS/Edit/5
    public async Task<IActionResult> Edit(int? itemid)
    {
        if (itemid == null)
        {
            return NotFound();
        }

        var item = await _context.ItemInfos.FindAsync(itemid);
        if (item == null)
        {
            return NotFound();
        }
        return View(item);
    }

    // POST: ITEMS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? itemid, [Bind("ItemId,Name,Category,PurchaseDate,Quantity,Price")] Item item)
    {
        if (itemid != item.ItemId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(item.ItemId))
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
        return View(item);
    }

    // GET: ITEMS/Delete/5
    public async Task<IActionResult> Delete(int? itemid)
    {
        if (itemid == null)
        {
            return NotFound();
        }

        var item = await _context.ItemInfos
            .FirstOrDefaultAsync(m => m.ItemId == itemid);
        if (item == null)
        {
            return NotFound();
        }

        return View(item);
    }

    // POST: ITEMS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? itemid)
    {
        var item = await _context.ItemInfos.FindAsync(itemid);
        if (item != null)
        {
            _context.ItemInfos.Remove(item);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ItemExists(int? itemid)
    {
        return _context.ItemInfos.Any(e => e.ItemId == itemid);
    }
}
