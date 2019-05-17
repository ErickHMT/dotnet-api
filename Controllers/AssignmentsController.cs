using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using webApi.Domain.Models;
using webApi.Domain.Services;
using webApi.Resources;
using webApi.Extensions;

namespace webApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase {

        private readonly IAssignmentService _assignmentService;
        private readonly IMapper _mapper;

        public AssignmentsController(IAssignmentService assignmentService, IMapper mapper) {
            _assignmentService = assignmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AssignmentDTO>> GetAllAsync() {
            var assignments = await _assignmentService.ListAsync();
            return _mapper.Map<IEnumerable<Assignment>, IEnumerable<AssignmentDTO>>(assignments);
        }


        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "";
        //}

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] AssignmentDTO assignmentDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var assignment = _mapper.Map<AssignmentDTO, Assignment>(assignmentDTO);
        }

        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
