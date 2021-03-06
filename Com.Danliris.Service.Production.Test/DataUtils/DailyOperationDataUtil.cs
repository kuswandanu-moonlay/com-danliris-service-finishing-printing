﻿using Com.Danliris.Service.Finishing.Printing.Lib.BusinessLogic.Facades.DailyOperation;
using Com.Danliris.Service.Finishing.Printing.Lib.Models.Daily_Operation;
using Com.Danliris.Service.Finishing.Printing.Test.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Danliris.Service.Finishing.Printing.Test.DataUtils
{
    public class DailyOperationDataUtil : BaseDataUtil<DailyOperationFacade, DailyOperationModel>
    {
        KanbanDataUtil kanbanDataUtil;
        public DailyOperationDataUtil(KanbanDataUtil kanbanDataUtil, DailyOperationFacade facade) : base(facade)
        {
            this.kanbanDataUtil = kanbanDataUtil;
        }

        public override async Task<DailyOperationModel> GetNewDataAsync()
        {
            var kanbanData = await kanbanDataUtil.GetTestData();

            DailyOperationModel model = new DailyOperationModel
            {
                KanbanId = kanbanData.Id,
                MachineId = kanbanData.Instruction.Steps.First().MachineId,
                BadOutputReasons = new List<DailyOperationBadOutputReasonsModel>
                {
                    new DailyOperationBadOutputReasonsModel()
                }
            };
            return model;
        }
    }
}
