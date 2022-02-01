﻿global using System.Reflection;
global using Dapper;
global using Domain.Repository;
global using FluentValidation;
global using MediatR;
global using Microsoft.Data.Sqlite;
global using Domain.DTOs;
global using Domain.Interfaces;
global using Persistence;
global using BenefitsCalcAPI.Models;
global using Domain.ValueObjects;
global using Domain.Entities;
global using System.Collections.Immutable;
global using BenefitsCalcAPI.Extensions;
global using Domain.Commands;
global using Domain.Queries;
global using Domain.Services.Rates;
global using Services.CalculationRules;
global using Services;