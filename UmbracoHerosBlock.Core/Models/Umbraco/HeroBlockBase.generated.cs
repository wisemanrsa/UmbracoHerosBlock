//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.0.0+8685c7d
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace UmbracoHerosBlock.Core.UmbracoModels
{
	// Mixin Content Type with alias "heroBlockBase"
	/// <summary>HeroBlockBase</summary>
	public partial interface IHeroBlockBase : IPublishedElement
	{
		/// <summary>Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Description { get; }

		/// <summary>Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops Image { get; }

		/// <summary>Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Title { get; }
	}

	/// <summary>HeroBlockBase</summary>
	[PublishedModel("heroBlockBase")]
	public partial class HeroBlockBase : PublishedElementModel, IHeroBlockBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		public new const string ModelTypeAlias = "heroBlockBase";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<HeroBlockBase, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public HeroBlockBase(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description")]
		public virtual string Description => GetDescription(this, _publishedValueFallback);

		/// <summary>Static getter for Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetDescription(IHeroBlockBase that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "description");

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("image")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Image => GetImage(this, _publishedValueFallback);

		/// <summary>Static getter for Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetImage(IHeroBlockBase that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "image");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title")]
		public virtual string Title => GetTitle(this, _publishedValueFallback);

		/// <summary>Static getter for Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.0.0+8685c7d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetTitle(IHeroBlockBase that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "title");
	}
}
