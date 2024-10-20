﻿using System;
using System.Collections.Generic;

namespace ToDoList.Database.Models;

public partial class ToDoDataModel
{
    public int TaskId { get; set; }

    public string TaskTitle { get; set; } = null!;

    public string? TaskDescription { get; set; }

    public int? CategoryId { get; set; }

    public byte? PriorityLevel { get; set; }

    public string? Status { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? CompletedDate { get; set; }

    public virtual CategoryDataModel? Category { get; set; }

    public bool DeleteFlag { get; set; }
}