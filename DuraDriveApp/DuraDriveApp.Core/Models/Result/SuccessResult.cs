﻿
using System.Collections.Generic;
using DuraDriveApp.Core.Helpers.Enums;

namespace DuraDriveApp.Core.Models.Result
{
    /// <summary>
    /// Success result.
    /// </summary>
    public class SuccessResult<T> : Result<T>
    {
        private readonly T _data;
        public SuccessResult(T data)
        {
            _data = data;
        }
        public override ResultType ResultType => ResultType.Ok;

        public override List<string> Errors => new List<string>();

        public override T Data => _data;
    }
}
