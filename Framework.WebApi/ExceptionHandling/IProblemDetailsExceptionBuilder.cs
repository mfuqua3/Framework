﻿using System.Net;

namespace Framework.ExceptionHandling;

public interface IProblemDetailsExceptionBuilder
{
    IProblemDetailsExceptionBuilder Map<T>(HttpStatusCode code)
        where T : Exception;

    IProblemDetailsExceptionBuilder Map<T>(int statusCode, string statusType)
        where T : Exception;

    IProblemDetailsExceptionMapper Build();
}