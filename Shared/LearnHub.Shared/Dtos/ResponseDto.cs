﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LearnHub.Shared.Dtos;

public class Response<T>
{
    public T Data { get; set; }

    [JsonIgnore]
    public int StatusCode { get; set; }
    [JsonIgnore]
    public bool Result { get; set; }
    public List<string> Errors { get; set; }


    public static Response<T> Success(T data, int statusCode)
    {
        return new Response<T> { Data = data, StatusCode = statusCode, Result = true };
    }

    public static Response<T> Success( int statusCode)
    {
        return new Response<T> { Data = default(T), StatusCode = statusCode, Result = true };
    }

    public static Response<T> Fail(List<string> errors, int statusCode)
    {
        return new Response<T>
        {
            Errors = errors,
            StatusCode = statusCode,
            Result = false
        };
    }

    public static Response<T> Fail(string error, int statusCode)
    {
        return new Response<T> { Errors = new List<string>() { error }, StatusCode = statusCode, Result = false };
    }
}
