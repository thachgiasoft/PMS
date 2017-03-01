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
	/// Represents the DataRepository.ThuLaoCoiThiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoCoiThiDataSourceDesigner))]
	public class ThuLaoCoiThiDataSource : ProviderDataSource<ThuLaoCoiThi, ThuLaoCoiThiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiDataSource class.
		/// </summary>
		public ThuLaoCoiThiDataSource() : base(new ThuLaoCoiThiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoCoiThiDataSourceView used by the ThuLaoCoiThiDataSource.
		/// </summary>
		protected ThuLaoCoiThiDataSourceView ThuLaoCoiThiView
		{
			get { return ( View as ThuLaoCoiThiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoCoiThiDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoCoiThiSelectMethod SelectMethod
		{
			get
			{
				ThuLaoCoiThiSelectMethod selectMethod = ThuLaoCoiThiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoCoiThiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoCoiThiDataSourceView class that is to be
		/// used by the ThuLaoCoiThiDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoCoiThiDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoCoiThi, ThuLaoCoiThiKey> GetNewDataSourceView()
		{
			return new ThuLaoCoiThiDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoCoiThiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoCoiThiDataSourceView : ProviderDataSourceView<ThuLaoCoiThi, ThuLaoCoiThiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoCoiThiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoCoiThiDataSourceView(ThuLaoCoiThiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoCoiThiDataSource ThuLaoCoiThiOwner
		{
			get { return Owner as ThuLaoCoiThiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoCoiThiSelectMethod SelectMethod
		{
			get { return ThuLaoCoiThiOwner.SelectMethod; }
			set { ThuLaoCoiThiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoCoiThiService ThuLaoCoiThiProvider
		{
			get { return Provider as ThuLaoCoiThiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoCoiThi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoCoiThi> results = null;
			ThuLaoCoiThi item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2935_NamHoc;
			System.String sp2935_HocKy;
			System.String sp2935_DotThanhToan;
			System.Int32 sp2935_ReVal = (int)0;

			switch ( SelectMethod )
			{
				case ThuLaoCoiThiSelectMethod.Get:
					ThuLaoCoiThiKey entityKey  = new ThuLaoCoiThiKey();
					entityKey.Load(values);
					item = ThuLaoCoiThiProvider.Get(entityKey);
					results = new TList<ThuLaoCoiThi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoCoiThiSelectMethod.GetAll:
                    results = ThuLaoCoiThiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoCoiThiSelectMethod.GetPaged:
					results = ThuLaoCoiThiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoCoiThiSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoCoiThiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoCoiThiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoCoiThiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoCoiThiProvider.GetById(_id);
					results = new TList<ThuLaoCoiThi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ThuLaoCoiThiSelectMethod.QuyDoi:
					sp2935_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2935_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp2935_DotThanhToan = (System.String) EntityUtil.ChangeType(values["DotThanhToan"], typeof(System.String));
					results = ThuLaoCoiThiProvider.QuyDoi(sp2935_NamHoc, sp2935_HocKy, sp2935_DotThanhToan, ref sp2935_ReVal, StartIndex, PageSize);
					customOutput.Add("ReVal", sp2935_ReVal);
					break;
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
			if ( SelectMethod == ThuLaoCoiThiSelectMethod.Get || SelectMethod == ThuLaoCoiThiSelectMethod.GetById )
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
				ThuLaoCoiThi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoCoiThiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoCoiThi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoCoiThiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoCoiThiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoCoiThiDataSource class.
	/// </summary>
	public class ThuLaoCoiThiDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoCoiThi, ThuLaoCoiThiKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiDataSourceDesigner class.
		/// </summary>
		public ThuLaoCoiThiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoCoiThiSelectMethod SelectMethod
		{
			get { return ((ThuLaoCoiThiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoCoiThiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoCoiThiDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoCoiThiDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoCoiThiDataSourceActionList : DesignerActionList
	{
		private ThuLaoCoiThiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoCoiThiDataSourceActionList(ThuLaoCoiThiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoCoiThiSelectMethod SelectMethod
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

	#endregion ThuLaoCoiThiDataSourceActionList
	
	#endregion ThuLaoCoiThiDataSourceDesigner
	
	#region ThuLaoCoiThiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoCoiThiDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoCoiThiSelectMethod
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
		GetById,
		/// <summary>
		/// Represents the QuyDoi method.
		/// </summary>
		QuyDoi
	}
	
	#endregion ThuLaoCoiThiSelectMethod

	#region ThuLaoCoiThiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiFilter : SqlFilter<ThuLaoCoiThiColumn>
	{
	}
	
	#endregion ThuLaoCoiThiFilter

	#region ThuLaoCoiThiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiExpressionBuilder : SqlExpressionBuilder<ThuLaoCoiThiColumn>
	{
	}
	
	#endregion ThuLaoCoiThiExpressionBuilder	

	#region ThuLaoCoiThiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoCoiThiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiProperty : ChildEntityProperty<ThuLaoCoiThiChildEntityTypes>
	{
	}
	
	#endregion ThuLaoCoiThiProperty
}

