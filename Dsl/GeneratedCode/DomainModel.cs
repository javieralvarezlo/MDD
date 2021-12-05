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
	/// DomainModel MPJAAMPrototoolDomainModel
	/// Description for UPM_IPS.MPJAAMPrototool.MPJAAMPrototool
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("978feb68-1d8d-4eb8-9203-c88ed5eb62d1")]
	public partial class MPJAAMPrototoolDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// MPJAAMPrototoolDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x978feb68, 0x1d8d, 0x4eb8, 0x92, 0x03, 0xc8, 0x8e, 0xd5, 0xeb, 0x62, 0xd1);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public MPJAAMPrototoolDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(TapizPrototool),
				typeof(Ventana),
				typeof(VentanaPrincipal),
				typeof(VentanaSecundaria),
				typeof(Menu),
				typeof(ItemNavegacion),
				typeof(ItemMenu),
				typeof(Boton),
				typeof(EstadoFin),
				typeof(TapizPrototoolHasVentanaPrincipal),
				typeof(TapizPrototoolHasVentanaSecundarium),
				typeof(VentanaHasMenus),
				typeof(MenuHasItemMenus),
				typeof(VentanaHasBotons),
				typeof(ItemNavegacionReferencesVentana),
				typeof(TapizPrototoolHasEstadoFin),
				typeof(ItemNavegacionReferencesEstadoFin),
				typeof(MPJAAMPrototoolDiagram),
				typeof(ItemNavegacion_Ventana),
				typeof(ItemNavegacion_EstadoFinMetafora),
				typeof(VPrincipalMetafora),
				typeof(VSecundariaMetafora),
				typeof(MenuMetafora),
				typeof(ItemMenuMetafora),
				typeof(BotonMetafora),
				typeof(EstadoFinMetafora),
				typeof(global::UPM_IPS.MPJAAMPrototool.FixUpDiagram),
				typeof(global::UPM_IPS.MPJAAMPrototool.ConnectorRolePlayerChanged),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(TapizPrototool), "nombreAplicacion", TapizPrototool.nombreAplicacionDomainPropertyId, typeof(TapizPrototool.nombreAplicacionPropertyHandler)),
				new DomainMemberInfo(typeof(Ventana), "nombre", Ventana.nombreDomainPropertyId, typeof(Ventana.nombrePropertyHandler)),
				new DomainMemberInfo(typeof(Ventana), "ancho", Ventana.anchoDomainPropertyId, typeof(Ventana.anchoPropertyHandler)),
				new DomainMemberInfo(typeof(Ventana), "altura", Ventana.alturaDomainPropertyId, typeof(Ventana.alturaPropertyHandler)),
				new DomainMemberInfo(typeof(VentanaSecundaria), "modal", VentanaSecundaria.modalDomainPropertyId, typeof(VentanaSecundaria.modalPropertyHandler)),
				new DomainMemberInfo(typeof(Menu), "TituloMenu", Menu.TituloMenuDomainPropertyId, typeof(Menu.TituloMenuPropertyHandler)),
				new DomainMemberInfo(typeof(ItemNavegacion), "titulo", ItemNavegacion.tituloDomainPropertyId, typeof(ItemNavegacion.tituloPropertyHandler)),
				new DomainMemberInfo(typeof(ItemMenu), "TituloItemMenu", ItemMenu.TituloItemMenuDomainPropertyId, typeof(ItemMenu.TituloItemMenuPropertyHandler)),
				new DomainMemberInfo(typeof(Boton), "TituloBoton", Boton.TituloBotonDomainPropertyId, typeof(Boton.TituloBotonPropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(TapizPrototoolHasVentanaPrincipal), "TapizPrototool", TapizPrototoolHasVentanaPrincipal.TapizPrototoolDomainRoleId),
				new DomainRolePlayerInfo(typeof(TapizPrototoolHasVentanaPrincipal), "VentanaPrincipal", TapizPrototoolHasVentanaPrincipal.VentanaPrincipalDomainRoleId),
				new DomainRolePlayerInfo(typeof(TapizPrototoolHasVentanaSecundarium), "TapizPrototool", TapizPrototoolHasVentanaSecundarium.TapizPrototoolDomainRoleId),
				new DomainRolePlayerInfo(typeof(TapizPrototoolHasVentanaSecundarium), "VentanaSecundaria", TapizPrototoolHasVentanaSecundarium.VentanaSecundariaDomainRoleId),
				new DomainRolePlayerInfo(typeof(VentanaHasMenus), "Ventana", VentanaHasMenus.VentanaDomainRoleId),
				new DomainRolePlayerInfo(typeof(VentanaHasMenus), "Menu", VentanaHasMenus.MenuDomainRoleId),
				new DomainRolePlayerInfo(typeof(MenuHasItemMenus), "Menu", MenuHasItemMenus.MenuDomainRoleId),
				new DomainRolePlayerInfo(typeof(MenuHasItemMenus), "ItemMenu", MenuHasItemMenus.ItemMenuDomainRoleId),
				new DomainRolePlayerInfo(typeof(VentanaHasBotons), "Ventana", VentanaHasBotons.VentanaDomainRoleId),
				new DomainRolePlayerInfo(typeof(VentanaHasBotons), "Boton", VentanaHasBotons.BotonDomainRoleId),
				new DomainRolePlayerInfo(typeof(ItemNavegacionReferencesVentana), "ItemNavegacion", ItemNavegacionReferencesVentana.ItemNavegacionDomainRoleId),
				new DomainRolePlayerInfo(typeof(ItemNavegacionReferencesVentana), "Ventana", ItemNavegacionReferencesVentana.VentanaDomainRoleId),
				new DomainRolePlayerInfo(typeof(TapizPrototoolHasEstadoFin), "TapizPrototool", TapizPrototoolHasEstadoFin.TapizPrototoolDomainRoleId),
				new DomainRolePlayerInfo(typeof(TapizPrototoolHasEstadoFin), "EstadoFin", TapizPrototoolHasEstadoFin.EstadoFinDomainRoleId),
				new DomainRolePlayerInfo(typeof(ItemNavegacionReferencesEstadoFin), "ItemNavegacion", ItemNavegacionReferencesEstadoFin.ItemNavegacionDomainRoleId),
				new DomainRolePlayerInfo(typeof(ItemNavegacionReferencesEstadoFin), "EstadoFin", ItemNavegacionReferencesEstadoFin.EstadoFinDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(18);
				createElementMap.Add(typeof(TapizPrototool), 0);
				createElementMap.Add(typeof(VentanaPrincipal), 1);
				createElementMap.Add(typeof(VentanaSecundaria), 2);
				createElementMap.Add(typeof(Menu), 3);
				createElementMap.Add(typeof(ItemMenu), 4);
				createElementMap.Add(typeof(Boton), 5);
				createElementMap.Add(typeof(EstadoFin), 6);
				createElementMap.Add(typeof(MPJAAMPrototoolDiagram), 7);
				createElementMap.Add(typeof(ItemNavegacion_Ventana), 8);
				createElementMap.Add(typeof(ItemNavegacion_EstadoFinMetafora), 9);
				createElementMap.Add(typeof(VPrincipalMetafora), 10);
				createElementMap.Add(typeof(VSecundariaMetafora), 11);
				createElementMap.Add(typeof(MenuMetafora), 12);
				createElementMap.Add(typeof(ItemMenuMetafora), 13);
				createElementMap.Add(typeof(BotonMetafora), 14);
				createElementMap.Add(typeof(EstadoFinMetafora), 15);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new TapizPrototool(partition, propertyAssignments);
				case 1: return new VentanaPrincipal(partition, propertyAssignments);
				case 2: return new VentanaSecundaria(partition, propertyAssignments);
				case 3: return new Menu(partition, propertyAssignments);
				case 4: return new ItemMenu(partition, propertyAssignments);
				case 5: return new Boton(partition, propertyAssignments);
				case 6: return new EstadoFin(partition, propertyAssignments);
				case 7: return new MPJAAMPrototoolDiagram(partition, propertyAssignments);
				case 8: return new ItemNavegacion_Ventana(partition, propertyAssignments);
				case 9: return new ItemNavegacion_EstadoFinMetafora(partition, propertyAssignments);
				case 10: return new VPrincipalMetafora(partition, propertyAssignments);
				case 11: return new VSecundariaMetafora(partition, propertyAssignments);
				case 12: return new MenuMetafora(partition, propertyAssignments);
				case 13: return new ItemMenuMetafora(partition, propertyAssignments);
				case 14: return new BotonMetafora(partition, propertyAssignments);
				case 15: return new EstadoFinMetafora(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(8);
				createElementLinkMap.Add(typeof(TapizPrototoolHasVentanaPrincipal), 0);
				createElementLinkMap.Add(typeof(TapizPrototoolHasVentanaSecundarium), 1);
				createElementLinkMap.Add(typeof(VentanaHasMenus), 2);
				createElementLinkMap.Add(typeof(MenuHasItemMenus), 3);
				createElementLinkMap.Add(typeof(VentanaHasBotons), 4);
				createElementLinkMap.Add(typeof(ItemNavegacionReferencesVentana), 5);
				createElementLinkMap.Add(typeof(TapizPrototoolHasEstadoFin), 6);
				createElementLinkMap.Add(typeof(ItemNavegacionReferencesEstadoFin), 7);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new TapizPrototoolHasVentanaPrincipal(partition, roleAssignments, propertyAssignments);
				case 1: return new TapizPrototoolHasVentanaSecundarium(partition, roleAssignments, propertyAssignments);
				case 2: return new VentanaHasMenus(partition, roleAssignments, propertyAssignments);
				case 3: return new MenuHasItemMenus(partition, roleAssignments, propertyAssignments);
				case 4: return new VentanaHasBotons(partition, roleAssignments, propertyAssignments);
				case 5: return new ItemNavegacionReferencesVentana(partition, roleAssignments, propertyAssignments);
				case 6: return new TapizPrototoolHasEstadoFin(partition, roleAssignments, propertyAssignments);
				case 7: return new ItemNavegacionReferencesEstadoFin(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return MPJAAMPrototoolDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (MPJAAMPrototoolDomainModel.resourceManager == null)
				{
					MPJAAMPrototoolDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(MPJAAMPrototoolDomainModel).Assembly);
				}
				return MPJAAMPrototoolDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return MPJAAMPrototoolDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return MPJAAMPrototoolDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (MPJAAMPrototoolDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new MPJAAMPrototoolCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					MPJAAMPrototoolDomainModel.copyClosure = copyFilter;
				}
				return MPJAAMPrototoolDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (MPJAAMPrototoolDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new MPJAAMPrototoolDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					MPJAAMPrototoolDomainModel.removeClosure = removeFilter;
				}
				return MPJAAMPrototoolDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::UPM_IPS.MPJAAMPrototool.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::UPM_IPS.MPJAAMPrototool.ConnectorRolePlayerChanged));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::UPM_IPS.MPJAAMPrototool.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::UPM_IPS.MPJAAMPrototool.ConnectorRolePlayerChanged));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class MPJAAMPrototoolDeleteClosure : MPJAAMPrototoolDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public MPJAAMPrototoolDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class MPJAAMPrototoolDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public MPJAAMPrototoolDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanaPrincipal.VentanaPrincipalDomainRoleId, true);
			DomainRoles.Add(global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanaSecundarium.VentanaSecundariaDomainRoleId, true);
			DomainRoles.Add(global::UPM_IPS.MPJAAMPrototool.VentanaHasMenus.MenuDomainRoleId, true);
			DomainRoles.Add(global::UPM_IPS.MPJAAMPrototool.MenuHasItemMenus.ItemMenuDomainRoleId, true);
			DomainRoles.Add(global::UPM_IPS.MPJAAMPrototool.VentanaHasBotons.BotonDomainRoleId, true);
			DomainRoles.Add(global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasEstadoFin.EstadoFinDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class MPJAAMPrototoolCopyClosure : MPJAAMPrototoolCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public MPJAAMPrototoolCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class MPJAAMPrototoolCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public MPJAAMPrototoolCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}

