﻿namespace PackIT.Shared.Abstractions.Exceptions;

public abstract class PackITException : Exception
{
    protected PackITException(string msg) : base(msg)
    {
        
    }
}