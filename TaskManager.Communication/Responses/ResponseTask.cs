﻿using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;

public class ResponseTask
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Type { get; set; }
    public DateTime LimitDate { get; set; }
    public Status Status { get; set; }
}
