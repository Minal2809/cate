using category.CatData;
using category.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace category.Controllers;

[ApiController]
[Route("api/[controller]")] //  api/category

public class CategoryController(Setcat setcat) : ControllerBase
{

  [HttpGet]
  public async Task<ActionResult<IEnumerable<CatEntity>>> GetCat()
  {
    var Result = await setcat.Cat_Table.ToListAsync();
    return Result ;
  }

  [HttpGet("{id:int}")]
  public async Task<ActionResult<CatEntity>> GetCat(int id)
  {
    var Results = await setcat.Cat_Table.FindAsync(id);

    return Results ;
  }
}

