﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace UPM_IPS.MPJAAMPrototool
{
	/// <summary>
	/// DomainClass ItemNavegacion_Ventana
	/// Description for UPM_IPS.MPJAAMPrototool.ItemNavegacion_Ventana
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.ItemNavegacion_Ventana.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.ItemNavegacion_Ventana.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("753407dd-edb2-4483-912b-db98fabf920e")]
	public partial class ItemNavegacion_Ventana : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ItemNavegacion_Ventana.
		/// </summary>
		public static DslDiagrams::Decorator FindItemNavegacion_VentanaDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes resources associated with this connector instance.
		/// </summary>
		protected override void InitializeInstanceResources()
		{
			base.InitializeInstanceResources();
			this.SetDecorators(null, new DslDiagrams::SizeD(0.1,0.1), DslDiagrams::LinkDecorator.DecoratorFilledArrow, new DslDiagrams::SizeD(0.1,0.1), false);
		}
		
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ItemNavegacion_Ventana domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x753407dd, 0xedb2, 0x4483, 0x91, 0x2b, 0xdb, 0x98, 0xfa, 0xbf, 0x92, 0x0e);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ItemNavegacion_Ventana(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ItemNavegacion_Ventana(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace UPM_IPS.MPJAAMPrototool
{
	/// <summary>
	/// DomainClass ItemNavegacion_EstadoFinMetafora
	/// Description for UPM_IPS.MPJAAMPrototool.ItemNavegacion_EstadoFinMetafora
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.ItemNavegacion_EstadoFinMetafora.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.ItemNavegacion_EstadoFinMetafora.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("32dcfaab-8fe4-4e11-95ec-2692e0d7bfe5")]
	public partial class ItemNavegacion_EstadoFinMetafora : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ItemNavegacion_EstadoFinMetafora.
		/// </summary>
		public static DslDiagrams::Decorator FindItemNavegacion_EstadoFinMetaforaDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes resources associated with this connector instance.
		/// </summary>
		protected override void InitializeInstanceResources()
		{
			base.InitializeInstanceResources();
			this.SetDecorators(null, new DslDiagrams::SizeD(0.1,0.1), DslDiagrams::LinkDecorator.DecoratorEmptyArrow, new DslDiagrams::SizeD(0.1,0.1), false);
		}
		
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ItemNavegacion_EstadoFinMetafora domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x32dcfaab, 0x8fe4, 0x4e11, 0x95, 0xec, 0x26, 0x92, 0xe0, 0xd7, 0xbf, 0xe5);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ItemNavegacion_EstadoFinMetafora(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ItemNavegacion_EstadoFinMetafora(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
