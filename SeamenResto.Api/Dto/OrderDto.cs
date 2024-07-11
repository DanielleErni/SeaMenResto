﻿namespace SeamenResto.Api.Dto;

public record class OrderDto
(
    int Id,
    string CustomerName,
    int Quantity,
    string OrderName,
    double Price
);
