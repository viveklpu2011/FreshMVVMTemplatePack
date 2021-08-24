﻿
using System.Collections.Generic;
using DuraDriveApp.Core.Helpers.Enums;

namespace DuraDriveApp.Core.Models.Result
{
    /// <summary>
    /// Unexpected result.
    /// </summary>
    public class UnexpectedResult<T> : Result<T>
    {
        public override ResultType ResultType => ResultType.Unexpected;

        public override List<string> Errors => new List<string> { "There was an unexpected problem" };

        public override T Data => default(T);
    }
}
