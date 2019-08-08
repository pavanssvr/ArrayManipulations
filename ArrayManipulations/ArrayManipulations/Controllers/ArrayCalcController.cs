using BAL;
using Microsoft.AspNetCore.Mvc;

namespace ArrayManipulations.Controllers
{
    [Route("api/[controller]")]
    public class ArrayCalcController : Controller
    {
        private readonly IArrayManipulationsService _arrayManipulationsService;

        public ArrayCalcController(IArrayManipulationsService arrayManipulationsService)
        {
            _arrayManipulationsService = arrayManipulationsService;
        }

        /// <summary>
        /// Reverse Array elements
        /// </summary>
        /// <param name="productIds"></param>
        /// <returns></returns>
        [HttpGet("Reverse")]
        public int[] Get([FromQuery] int[] productIds) => _arrayManipulationsService.ReverseArray(productIds);

        /// <summary>
        /// Remove element from Array based on position input
        /// </summary>
        /// <param name="position"></param>
        /// <param name="productIds"></param>
        /// <returns></returns>
        [HttpGet("DeletePart")]
        public int[] Get(int position, [FromQuery] int[] productIds) => _arrayManipulationsService.RemoveElementFromArray(position, productIds);
    }
}
