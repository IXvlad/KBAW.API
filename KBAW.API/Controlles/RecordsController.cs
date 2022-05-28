using System;
using System.Collections.Generic;
using KBAW.Query.EFServices.Interfaces;
using KBAW.Query.EFServices.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KBAW.API.Controlles
{
    [ApiController]
    [Route("[controller]")]
    public class RecordsController : ControllerBase
    {
        private readonly Lazy<IGetAllRecordsCommand> _getAllRecordsCommand;

        public RecordsController(
            Lazy<IGetAllRecordsCommand> getAllRecordsCommand)
        {
            _getAllRecordsCommand = getAllRecordsCommand;
        }

        [HttpGet("GetAllRecords")]
        public IEnumerable<Record> GetAllRecords()
        {
            return _getAllRecordsCommand.Value.Get();
        }
    }
}