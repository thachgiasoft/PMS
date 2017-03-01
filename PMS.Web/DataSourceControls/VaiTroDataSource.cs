#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.VaiTroProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(VaiTroDataSourceDesigner))]
	public class VaiTroDataSource : ProviderDataSource<VaiTro, VaiTroKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VaiTroDataSource class.
		/// </summary>
		public VaiTroDataSource() : base(new VaiTroService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VaiTroDataSourceView used by the VaiTroDataSource.
		/// </summary>
		protected VaiTroDataSourceView VaiTroView
		{
			get { return ( View as VaiTroDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the VaiTroDataSource control invokes to retrieve data.
		/// </summary>
		public VaiTroSelectMethod SelectMethod
		{
			get
			{
				VaiTroSelectMethod selectMethod = VaiTroSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (VaiTroSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VaiTroDataSourceView class that is to be
		/// used by the VaiTroDataSource.
		/// </summary>
		/// <returns>An instance of the VaiTroDataSourceView class.</returns>
		protected override BaseDataSourceView<VaiTro, VaiTroKey> GetNewDataSourceView()
		{
			return new VaiTroDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the VaiTroDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VaiTroDataSourceView : ProviderDataSourceView<VaiTro, VaiTroKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VaiTroDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VaiTroDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VaiTroDataSourceView(VaiTroDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VaiTroDataSource VaiTroOwner
		{
			get { return Owner as VaiTroDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal VaiTroSelectMethod SelectMethod
		{
			get { return VaiTroOwner.SelectMethod; }
			set { VaiTroOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VaiTroService VaiTroProvider
		{
			get { return Provider as VaiTroService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<VaiTro> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<VaiTro> results = null;
			VaiTro item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case VaiTroSelectMethod.Get:
					VaiTroKey entityKey  = new VaiTroKey();
					entityKey.Load(values);
					item = VaiTroProvider.Get(entityKey);
					results = new TList<VaiTro>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case VaiTroSelectMethod.GetAll:
                    results = VaiTroProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case VaiTroSelectMethod.GetPaged:
					results = VaiTroProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case VaiTroSelectMethod.Find:
					if ( FilterParameters != null )
						results = VaiTroProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = VaiTroProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case VaiTroSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = VaiTroProvider.GetById(_id);
					results = new TList<VaiTro>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == VaiTroSelectMethod.Get || SelectMethod == VaiTroSelectMethod.GetById )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				VaiTro entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					VaiTroProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<VaiTro> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			VaiTroProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region VaiTroDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VaiTroDataSource class.
	/// </summary>
	public class VaiTroDataSourceDesigner : ProviderDataSourceDesigner<VaiTro, VaiTroKey>
	{
		/// <summary>
		/// Initializes a new instance of the VaiTroDataSourceDesigner class.
		/// </summary>
		public VaiTroDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public VaiTroSelectMethod SelectMethod
		{
			get { return ((VaiTroDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new VaiTroDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region VaiTroDataSourceActionList

	/// <summary>
	/// Supports the VaiTroDataSourceDesigner class.
	/// </summary>
	internal class VaiTroDataSourceActionList : DesignerActionList
	{
		private VaiTroDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the VaiTroDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public VaiTroDataSourceActionList(VaiTroDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public VaiTroSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion VaiTroDataSourceActionList
	
	#endregion VaiTroDataSourceDesigner
	
	#region VaiTroSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the VaiTroDataSource.SelectMethod property.
	/// </summary>
	public enum VaiTroSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetById method.
		/// </summary>
		GetById
	}
	
	#endregion VaiTroSelectMethod

	#region VaiTroFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VaiTro"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VaiTroFilter : SqlFilter<VaiTroColumn>
	{
	}
	
	#endregion VaiTroFilter

	#region VaiTroExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VaiTro"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VaiTroExpressionBuilder : SqlExpressionBuilder<VaiTroColumn>
	{
	}
	
	#endregion VaiTroExpressionBuilder	

	#region VaiTroProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;VaiTroChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="VaiTro"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VaiTroProperty : ChildEntityProperty<VaiTroChildEntityTypes>
	{
	}
	
	#endregion VaiTroProperty
}

