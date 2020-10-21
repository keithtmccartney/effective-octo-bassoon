using BlazorModal.Services;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorModal
{
	public class ModalBase : BlazorComponent, IDisposable
	{
		[Inject] ModalService ModalService { get; set; }

		protected bool IsVisible { get; set; }
		protected string Title { get; set; }
		protected RenderFragment Content { get; set; }

		protected override void OnInit()
		{
			ModalService.OnShow += ShowModal;
			ModalService.OnClose += CloseModal;
		}

		public void CloseModal()
		{
			IsVisible = false;

			Title = "";

			Content = null;

			StateHasChanged();
		}

		public void ShowModal(string title, RenderFragment content)
		{
			Title = title;

			Content = content;

			IsVisible = true;

			StateHasChanged();
		}

		public void Dispose()
		{
			ModalService.OnShow -= ShowModal;
			ModalService.OnClose -= CloseModal;
		}
	}
}
