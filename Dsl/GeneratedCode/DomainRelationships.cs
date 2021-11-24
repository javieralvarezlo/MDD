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
namespace UPM_IPS.MPJAAMPrototool
{
	/// <summary>
	/// DomainRelationship TapizPrototoolHasVentanas
	/// Description for UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("3110b838-aee1-4ede-8d3b-159c68d0c5f5")]
	public partial class TapizPrototoolHasVentanas : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// TapizPrototoolHasVentanas domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x3110b838, 0xaee1, 0x4ede, 0x8d, 0x3b, 0x15, 0x9c, 0x68, 0xd0, 0xc5, 0xf5);
	
				
		/// <summary>
		/// Constructor
		/// Creates a TapizPrototoolHasVentanas link in the same Partition as the given TapizPrototool
		/// </summary>
		/// <param name="source">TapizPrototool to use as the source of the relationship.</param>
		/// <param name="target">Ventana to use as the target of the relationship.</param>
		public TapizPrototoolHasVentanas(TapizPrototool source, Ventana target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(TapizPrototoolHasVentanas.TapizPrototoolDomainRoleId, source), new DslModeling::RoleAssignment(TapizPrototoolHasVentanas.VentanaDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public TapizPrototoolHasVentanas(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public TapizPrototoolHasVentanas(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public TapizPrototoolHasVentanas(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public TapizPrototoolHasVentanas(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region TapizPrototool domain role code
		
		/// <summary>
		/// TapizPrototool domain role Id.
		/// </summary>
		public static readonly global::System.Guid TapizPrototoolDomainRoleId = new global::System.Guid(0x14b11b21, 0x846f, 0x43a6, 0x98, 0x85, 0x08, 0x24, 0x65, 0x16, 0x70, 0xab);
		
		/// <summary>
		/// DomainRole TapizPrototool
		/// Description for UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas.TapizPrototool
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas/TapizPrototool.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas/TapizPrototool.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Ventanas", PropertyDisplayNameKey="UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas/TapizPrototool.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("14b11b21-846f-43a6-9885-0824651670ab")]
		public virtual TapizPrototool TapizPrototool
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (TapizPrototool)DslModeling::DomainRoleInfo.GetRolePlayer(this, TapizPrototoolDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TapizPrototoolDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access TapizPrototool of a Ventana
		/// <summary>
		/// Gets TapizPrototool.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static TapizPrototool GetTapizPrototool(Ventana element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, VentanaDomainRoleId) as TapizPrototool;
		}
		
		/// <summary>
		/// Sets TapizPrototool.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetTapizPrototool(Ventana element, TapizPrototool newTapizPrototool)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, VentanaDomainRoleId, newTapizPrototool);
		}
		#endregion
		#region Ventana domain role code
		
		/// <summary>
		/// Ventana domain role Id.
		/// </summary>
		public static readonly global::System.Guid VentanaDomainRoleId = new global::System.Guid(0x7e36a506, 0x3667, 0x4514, 0x86, 0x2d, 0x54, 0x32, 0x01, 0x53, 0xc5, 0x03);
		
		/// <summary>
		/// DomainRole Ventana
		/// Description for UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas.Ventana
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas/Ventana.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas/Ventana.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "TapizPrototool", PropertyDisplayNameKey="UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas/Ventana.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("7e36a506-3667-4514-862d-54320153c503")]
		public virtual Ventana Ventana
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Ventana)DslModeling::DomainRoleInfo.GetRolePlayer(this, VentanaDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, VentanaDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Ventanas of a TapizPrototool
		/// <summary>
		/// Gets a list of Ventanas.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<Ventana> GetVentanas(TapizPrototool element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<Ventana>, Ventana>(element, TapizPrototoolDomainRoleId);
		}
		#endregion
		#region TapizPrototool link accessor
		/// <summary>
		/// Get the list of TapizPrototoolHasVentanas links to a TapizPrototool.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas> GetLinksToVentanas ( global::UPM_IPS.MPJAAMPrototool.TapizPrototool tapizPrototoolInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas>(tapizPrototoolInstance, global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas.TapizPrototoolDomainRoleId);
		}
		#endregion
		#region Ventana link accessor
		/// <summary>
		/// Get the TapizPrototoolHasVentanas link to a Ventana.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas GetLinkToTapizPrototool (global::UPM_IPS.MPJAAMPrototool.Ventana ventanaInstance)
		{
			global::System.Collections.Generic.IList<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas>(ventanaInstance, global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas.VentanaDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Ventana not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region TapizPrototoolHasVentanas instance accessors
		
		/// <summary>
		/// Get any TapizPrototoolHasVentanas links between a given TapizPrototool and a Ventana.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas> GetLinks( global::UPM_IPS.MPJAAMPrototool.TapizPrototool source, global::UPM_IPS.MPJAAMPrototool.Ventana target )
		{
			global::System.Collections.Generic.List<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas> outLinks = new global::System.Collections.Generic.List<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas>();
			global::System.Collections.Generic.IList<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas>(source, global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas.TapizPrototoolDomainRoleId);
			foreach ( global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas link in links )
			{
				if ( target.Equals(link.Ventana) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one TapizPrototoolHasVentanas link between a given TapizPrototooland a Ventana.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas GetLink( global::UPM_IPS.MPJAAMPrototool.TapizPrototool source, global::UPM_IPS.MPJAAMPrototool.Ventana target )
		{
			global::System.Collections.Generic.IList<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas>(source, global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas.TapizPrototoolDomainRoleId);
			foreach ( global::UPM_IPS.MPJAAMPrototool.TapizPrototoolHasVentanas link in links )
			{
				if ( target.Equals(link.Ventana) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace UPM_IPS.MPJAAMPrototool
{
	/// <summary>
	/// DomainRelationship VPrincipalReferencesVSecundaria
	/// Description for UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship()]
	[DslModeling::DomainObjectId("3be2ce36-b4c4-4580-9cbb-d7fb155f7b72")]
	public partial class VPrincipalReferencesVSecundaria : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// VPrincipalReferencesVSecundaria domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x3be2ce36, 0xb4c4, 0x4580, 0x9c, 0xbb, 0xd7, 0xfb, 0x15, 0x5f, 0x7b, 0x72);
	
				
		/// <summary>
		/// Constructor
		/// Creates a VPrincipalReferencesVSecundaria link in the same Partition as the given VentanaPrincipal
		/// </summary>
		/// <param name="source">VentanaPrincipal to use as the source of the relationship.</param>
		/// <param name="target">VentanaSecundaria to use as the target of the relationship.</param>
		public VPrincipalReferencesVSecundaria(VentanaPrincipal source, VentanaSecundaria target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(VPrincipalReferencesVSecundaria.VentanaPrincipalDomainRoleId, source), new DslModeling::RoleAssignment(VPrincipalReferencesVSecundaria.VentanaSecundariaDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public VPrincipalReferencesVSecundaria(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public VPrincipalReferencesVSecundaria(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public VPrincipalReferencesVSecundaria(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public VPrincipalReferencesVSecundaria(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region VentanaPrincipal domain role code
		
		/// <summary>
		/// VentanaPrincipal domain role Id.
		/// </summary>
		public static readonly global::System.Guid VentanaPrincipalDomainRoleId = new global::System.Guid(0xffcbf736, 0xe9ad, 0x4c99, 0x8f, 0x05, 0x64, 0xc4, 0xef, 0x7f, 0x42, 0xae);
		
		/// <summary>
		/// DomainRole VentanaPrincipal
		/// Description for
		/// UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria.VentanaPrincipal
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria/VentanaPrincipal.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria/VentanaPrincipal.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "VentanaSecundarium", PropertyDisplayNameKey="UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria/VentanaPrincipal.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("ffcbf736-e9ad-4c99-8f05-64c4ef7f42ae")]
		public virtual VentanaPrincipal VentanaPrincipal
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (VentanaPrincipal)DslModeling::DomainRoleInfo.GetRolePlayer(this, VentanaPrincipalDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, VentanaPrincipalDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access VentanaPrincipal of a VentanaSecundaria
		/// <summary>
		/// Gets VentanaPrincipal.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static VentanaPrincipal GetVentanaPrincipal(VentanaSecundaria element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, VentanaSecundariaDomainRoleId) as VentanaPrincipal;
		}
		
		/// <summary>
		/// Sets VentanaPrincipal.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetVentanaPrincipal(VentanaSecundaria element, VentanaPrincipal newVentanaPrincipal)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, VentanaSecundariaDomainRoleId, newVentanaPrincipal);
		}
		#endregion
		#region VentanaSecundaria domain role code
		
		/// <summary>
		/// VentanaSecundaria domain role Id.
		/// </summary>
		public static readonly global::System.Guid VentanaSecundariaDomainRoleId = new global::System.Guid(0x0c7b80d1, 0x26f0, 0x4ba8, 0xa5, 0x9d, 0x67, 0xb3, 0x81, 0xed, 0x62, 0xe8);
		
		/// <summary>
		/// DomainRole VentanaSecundaria
		/// Description for
		/// UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria.VentanaSecundaria
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria/VentanaSecundaria.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria/VentanaSecundaria.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "VentanaPrincipal", PropertyDisplayNameKey="UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria/VentanaSecundaria.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("0c7b80d1-26f0-4ba8-a59d-67b381ed62e8")]
		public virtual VentanaSecundaria VentanaSecundaria
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (VentanaSecundaria)DslModeling::DomainRoleInfo.GetRolePlayer(this, VentanaSecundariaDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, VentanaSecundariaDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access VentanaSecundarium of a VentanaPrincipal
		/// <summary>
		/// Gets a list of VentanaSecundarium.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<VentanaSecundaria> GetVentanaSecundarium(VentanaPrincipal element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<VentanaSecundaria>, VentanaSecundaria>(element, VentanaPrincipalDomainRoleId);
		}
		#endregion
		#region VentanaPrincipal link accessor
		/// <summary>
		/// Get the list of VPrincipalReferencesVSecundaria links to a VentanaPrincipal.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria> GetLinksToVentanaSecundarium ( global::UPM_IPS.MPJAAMPrototool.VentanaPrincipal ventanaPrincipalInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria>(ventanaPrincipalInstance, global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria.VentanaPrincipalDomainRoleId);
		}
		#endregion
		#region VentanaSecundaria link accessor
		/// <summary>
		/// Get the VPrincipalReferencesVSecundaria link to a VentanaSecundaria.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria GetLinkToVentanaPrincipal (global::UPM_IPS.MPJAAMPrototool.VentanaSecundaria ventanaSecundariaInstance)
		{
			global::System.Collections.Generic.IList<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria>(ventanaSecundariaInstance, global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria.VentanaSecundariaDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of VentanaSecundaria not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region VPrincipalReferencesVSecundaria instance accessors
		
		/// <summary>
		/// Get any VPrincipalReferencesVSecundaria links between a given VentanaPrincipal and a VentanaSecundaria.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria> GetLinks( global::UPM_IPS.MPJAAMPrototool.VentanaPrincipal source, global::UPM_IPS.MPJAAMPrototool.VentanaSecundaria target )
		{
			global::System.Collections.Generic.List<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria> outLinks = new global::System.Collections.Generic.List<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria>();
			global::System.Collections.Generic.IList<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria>(source, global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria.VentanaPrincipalDomainRoleId);
			foreach ( global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria link in links )
			{
				if ( target.Equals(link.VentanaSecundaria) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one VPrincipalReferencesVSecundaria link between a given VentanaPrincipaland a VentanaSecundaria.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria GetLink( global::UPM_IPS.MPJAAMPrototool.VentanaPrincipal source, global::UPM_IPS.MPJAAMPrototool.VentanaSecundaria target )
		{
			global::System.Collections.Generic.IList<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria>(source, global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria.VentanaPrincipalDomainRoleId);
			foreach ( global::UPM_IPS.MPJAAMPrototool.VPrincipalReferencesVSecundaria link in links )
			{
				if ( target.Equals(link.VentanaSecundaria) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace UPM_IPS.MPJAAMPrototool
{
	/// <summary>
	/// DomainRelationship VSecundariaReferencesVSecundaria
	/// Description for UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship()]
	[DslModeling::DomainObjectId("38b37c86-44e6-4201-9e04-13f79fc72b59")]
	public partial class VSecundariaReferencesVSecundaria : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// VSecundariaReferencesVSecundaria domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x38b37c86, 0x44e6, 0x4201, 0x9e, 0x04, 0x13, 0xf7, 0x9f, 0xc7, 0x2b, 0x59);
	
				
		/// <summary>
		/// Constructor
		/// Creates a VSecundariaReferencesVSecundaria link in the same Partition as the given VentanaSecundaria
		/// </summary>
		/// <param name="source">VentanaSecundaria to use as the source of the relationship.</param>
		/// <param name="target">VentanaSecundaria to use as the target of the relationship.</param>
		public VSecundariaReferencesVSecundaria(VentanaSecundaria source, VentanaSecundaria target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(VSecundariaReferencesVSecundaria.SourceVentanaSecundariaDomainRoleId, source), new DslModeling::RoleAssignment(VSecundariaReferencesVSecundaria.TargetVentanaSecundariaDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public VSecundariaReferencesVSecundaria(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public VSecundariaReferencesVSecundaria(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public VSecundariaReferencesVSecundaria(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public VSecundariaReferencesVSecundaria(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region SourceVentanaSecundaria domain role code
		
		/// <summary>
		/// SourceVentanaSecundaria domain role Id.
		/// </summary>
		public static readonly global::System.Guid SourceVentanaSecundariaDomainRoleId = new global::System.Guid(0x795aa0d5, 0x489e, 0x49cc, 0x96, 0x1d, 0x98, 0xb6, 0x61, 0xf0, 0x65, 0x25);
		
		/// <summary>
		/// DomainRole SourceVentanaSecundaria
		/// Description for
		/// UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria.SourceVentanaSecundaria
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria/SourceVentanaSecundaria.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria/SourceVentanaSecundaria.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "TargetVentanaSecundarium", PropertyDisplayNameKey="UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria/SourceVentanaSecundaria.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("795aa0d5-489e-49cc-961d-98b661f06525")]
		public virtual VentanaSecundaria SourceVentanaSecundaria
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (VentanaSecundaria)DslModeling::DomainRoleInfo.GetRolePlayer(this, SourceVentanaSecundariaDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, SourceVentanaSecundariaDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access SourceVentanaSecundarium of a VentanaSecundaria
		/// <summary>
		/// Gets a list of SourceVentanaSecundarium.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<VentanaSecundaria> GetSourceVentanaSecundarium(VentanaSecundaria element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<VentanaSecundaria>, VentanaSecundaria>(element, TargetVentanaSecundariaDomainRoleId);
		}
		#endregion
		#region TargetVentanaSecundaria domain role code
		
		/// <summary>
		/// TargetVentanaSecundaria domain role Id.
		/// </summary>
		public static readonly global::System.Guid TargetVentanaSecundariaDomainRoleId = new global::System.Guid(0x30e95320, 0xab9b, 0x4f49, 0xad, 0x85, 0x4a, 0xa4, 0x1e, 0x0b, 0x4c, 0x21);
		
		/// <summary>
		/// DomainRole TargetVentanaSecundaria
		/// Description for
		/// UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria.TargetVentanaSecundaria
		/// </summary>
		[DslDesign::DisplayNameResource("UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria/TargetVentanaSecundaria.DisplayName", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria/TargetVentanaSecundaria.Description", typeof(global::UPM_IPS.MPJAAMPrototool.MPJAAMPrototoolDomainModel), "UPM_IPS.MPJAAMPrototool.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "SourceVentanaSecundarium", PropertyDisplayNameKey="UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria/TargetVentanaSecundaria.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("30e95320-ab9b-4f49-ad85-4aa41e0b4c21")]
		public virtual VentanaSecundaria TargetVentanaSecundaria
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (VentanaSecundaria)DslModeling::DomainRoleInfo.GetRolePlayer(this, TargetVentanaSecundariaDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TargetVentanaSecundariaDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access TargetVentanaSecundarium of a VentanaSecundaria
		/// <summary>
		/// Gets a list of TargetVentanaSecundarium.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<VentanaSecundaria> GetTargetVentanaSecundarium(VentanaSecundaria element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<VentanaSecundaria>, VentanaSecundaria>(element, SourceVentanaSecundariaDomainRoleId);
		}
		#endregion
		#region SourceVentanaSecundaria link accessor
		/// <summary>
		/// Get the list of VSecundariaReferencesVSecundaria links to a VentanaSecundaria.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria> GetLinksToTargetVentanaSecundarium ( global::UPM_IPS.MPJAAMPrototool.VentanaSecundaria sourceVentanaSecundariaInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria>(sourceVentanaSecundariaInstance, global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria.SourceVentanaSecundariaDomainRoleId);
		}
		#endregion
		#region TargetVentanaSecundaria link accessor
		/// <summary>
		/// Get the list of VSecundariaReferencesVSecundaria links to a VentanaSecundaria.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria> GetLinksToSourceVentanaSecundarium ( global::UPM_IPS.MPJAAMPrototool.VentanaSecundaria targetVentanaSecundariaInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria>(targetVentanaSecundariaInstance, global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria.TargetVentanaSecundariaDomainRoleId);
		}
		#endregion
		#region VSecundariaReferencesVSecundaria instance accessors
		
		/// <summary>
		/// Get any VSecundariaReferencesVSecundaria links between a given VentanaSecundaria and a VentanaSecundaria.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria> GetLinks( global::UPM_IPS.MPJAAMPrototool.VentanaSecundaria source, global::UPM_IPS.MPJAAMPrototool.VentanaSecundaria target )
		{
			global::System.Collections.Generic.List<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria> outLinks = new global::System.Collections.Generic.List<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria>();
			global::System.Collections.Generic.IList<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria>(source, global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria.SourceVentanaSecundariaDomainRoleId);
			foreach ( global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria link in links )
			{
				if ( target.Equals(link.TargetVentanaSecundaria) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one VSecundariaReferencesVSecundaria link between a given VentanaSecundariaand a VentanaSecundaria.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria GetLink( global::UPM_IPS.MPJAAMPrototool.VentanaSecundaria source, global::UPM_IPS.MPJAAMPrototool.VentanaSecundaria target )
		{
			global::System.Collections.Generic.IList<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria> links = DslModeling::DomainRoleInfo.GetElementLinks<global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria>(source, global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria.SourceVentanaSecundariaDomainRoleId);
			foreach ( global::UPM_IPS.MPJAAMPrototool.VSecundariaReferencesVSecundaria link in links )
			{
				if ( target.Equals(link.TargetVentanaSecundaria) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
