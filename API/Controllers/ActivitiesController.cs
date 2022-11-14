using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    { 


        public ActivitiesController(ILogger<BaseApiController> logger) 
                    : base(logger)
        { 

        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
                return await Mediator.Send(new List.Query());
        }

         [HttpGet("{id}")]
         public async Task<ActionResult<Activity>> GetActivity(Guid id)
         {
            return  await Mediator.Send(new Detail.Query{ ActivityID = id });
         }

          [HttpPost]
         public async Task<IActionResult> CreateActivity([FromBody]Activity activity)
         {
            return  Ok(await Mediator.Send(new Create.Comamand{ Activity = activity })) ;
         }

        [HttpPut("{id}")]
         public async Task<IActionResult> UpdateActivity(Guid id, Activity activity)
         {
            activity.ID = id;           
            return  Ok(await Mediator.Send(new Update.Command{ Activity = activity })) ;
         }


    }
}