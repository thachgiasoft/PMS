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
	/// Represents the DataRepository.GiangVienTamUngChiTietProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienTamUngChiTietDataSourceDesigner))]
	public class GiangVienTamUngChiTietDataSource : ProviderDataSource<GiangVienTamUngChiTiet, GiangVienTamUngChiTietKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietDataSource class.
		/// </summary>
		public GiangVienTamUngChiTietDataSource() : base(new GiangVienTamUngChiTietService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienTamUngChiTietDataSourceView used by the GiangVienTamUngChiTietDataSource.
		/// </summary>
		protected GiangVienTamUngChiTietDataSourceView GiangVienTamUngChiTietView
		{
			get { return ( View as GiangVienTamUngChiTietDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienTamUngChiTietDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienTamUngChiTietSelectMethod SelectMethod
		{
			get
			{
				GiangVienTamUngChiTietSelectMethod selectMethod = GiangVienTamUngChiTietSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienTamUngChiTietSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienTamUngChiTietDataSourceView class that is to be
		/// used by the GiangVienTamUngChiTietDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienTamUngChiTietDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienTamUngChiTiet, GiangVienTamUngChiTietKey> GetNewDataSourceView()
		{
			return new GiangVienTamUngChiTietDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienTamUngChiTietDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienTamUngChiTietDataSourceView : ProviderDataSourceView<GiangVienTamUngChiTiet, GiangVienTamUngChiTietKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienTamUngChiTietDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienTamUngChiTietDataSourceView(GiangVienTamUngChiTietDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienTamUngChiTietDataSource GiangVienTamUngChiTietOwner
		{
			get { return Owner as GiangVienTamUngChiTietDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienTamUngChiTietSelectMethod SelectMethod
		{
			get { return GiangVienTamUngChiTietOwner.SelectMethod; }
			set { GiangVienTamUngChiTietOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienTamUngChiTietService GiangVienTamUngChiTietProvider
		{
			get { return Provider as GiangVienTamUngChiTietService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienTamUngChiTiet> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienTamUngChiTiet> results = null;
			GiangVienTamUngChiTiet item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case GiangVienTamUngChiTietSelectMethod.Get:
					GiangVienTamUngChiTietKey entityKey  = new GiangVienTamUngChiTietKey();
					entityKey.Load(values);
					item = GiangVienTamUngChiTietProvider.Get(entityKey);
					results = new TList<GiangVienTamUngChiTiet>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienTamUngChiTietSelectMethod.GetAll:
                    results = GiangVienTamUngChiTietProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienTamUngChiTietSelectMethod.GetPaged:
					results = GiangVienTamUngChiTietProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienTamUngChiTietSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienTamUngChiTietProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienTamUngChiTietProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienTamUngChiTietSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienTamUngChiTietProvider.GetById(_id);
					results = new TList<GiangVienTamUngChiTiet>();
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
			if ( SelectMethod == GiangVienTamUngChiTietSelectMethod.Get || SelectMethod == GiangVienTamUngChiTietSelectMethod.GetById )
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
				GiangVienTamUngChiTiet entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienTamUngChiTietProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienTamUngChiTiet> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienTamUngChiTietProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienTamUngChiTietDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienTamUngChiTietDataSource class.
	/// </summary>
	public class GiangVienTamUngChiTietDataSourceDesigner : ProviderDataSourceDesigner<GiangVienTamUngChiTiet, GiangVienTamUngChiTietKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietDataSourceDesigner class.
		/// </summary>
		public GiangVienTamUngChiTietDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienTamUngChiTietSelectMethod SelectMethod
		{
			get { return ((GiangVienTamUngChiTietDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienTamUngChiTietDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienTamUngChiTietDataSourceActionList

	/// <summary>
	/// Supports the GiangVienTamUngChiTietDataSourceDesigner class.
	/// </summary>
	internal class GiangVienTamUngChiTietDataSourceActionList : DesignerActionList
	{
		private GiangVienTamUngChiTietDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienTamUngChiTietDataSourceActionList(GiangVienTamUngChiTietDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienTamUngChiTietSelectMethod SelectMethod
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

	#endregion GiangVienTamUngChiTietDataSourceActionList
	
	#endregion GiangVienTamUngChiTietDataSourceDesigner
	
	#region GiangVienTamUngChiTietSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienTamUngChiTietDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienTamUngChiTietSelectMethod
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
	
	#endregion GiangVienTamUngChiTietSelectMethod

	#region GiangVienTamUngChiTietFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUngChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngChiTietFilter : SqlFilter<GiangVienTamUngChiTietColumn>
	{
	}
	
	#endregion GiangVienTamUngChiTietFilter

	#region GiangVienTamUngChiTietExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUngChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngChiTietExpressionBuilder : SqlExpressionBuilder<GiangVienTamUngChiTietColumn>
	{
	}
	
	#endregion GiangVienTamUngChiTietExpressionBuilder	

	#region GiangVienTamUngChiTietProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienTamUngChiTietChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUngChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngChiTietProperty : ChildEntityProperty<GiangVienTamUngChiTietChildEntityTypes>
	{
	}
	
	#endregion GiangVienTamUngChiTietProperty
}

