using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocationVehicule.Models;
using LocationVehicule.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocationVehicule.Controler
{
    [Route("api/Voitures")]
    [ApiController]
    public class GetVoitureController : ControllerBase
    {
        private readonly IVoitureRepository _voitureRepository;

        public GetVoitureController(IVoitureRepository voitureRepository)
        {
            _voitureRepository = voitureRepository;
        }
        
        [HttpPost]
        [Route("AddVoiture")]
        public IActionResult AddVoiture([FromBody] Voiture voitureParam)
        {
            try
            {
                if (ModelState.IsValid)
                {
                     _voitureRepository.Add(voitureParam);
                    return Ok();

                }

                else
                {
                    return BadRequest();
                }
            }

            catch
            {
                return BadRequest();
            }
        }



    }
}
