﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Tasks;
using Project.Tasks.Dtos;
using Shouldly;
using Xunit;

namespace Project.Tests.Tasks
{
    public class TaskAppService_Tests : ProjectTestBase
    {
        private readonly ITaskAppService _taskAppService;

        public TaskAppService_Tests()
        {
            _taskAppService = Resolve<ITaskAppService>();
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Tasks()
        {
            //Act
            var output = await _taskAppService.GetAll(new GetAllTasksInput());

            //Assert
            output.Items.Count.ShouldBe(2);
        }

        [Fact]
    public async System.Threading.Tasks.Task Should_Get_Filtered_Tasks()
    {
        //Act
        var output = await _taskAppService.GetAll(new GetAllTasksInput { State = TaskState.Open });

        //Assert
        output.Items.ShouldAllBe(t => t.State == TaskState.Open);
    }
    }
}
