using BlazorModal.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorModal
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddBlazorModal(this IServiceCollection services)
		{
			return services.AddScoped<ModalService>();
		}
	}
}
