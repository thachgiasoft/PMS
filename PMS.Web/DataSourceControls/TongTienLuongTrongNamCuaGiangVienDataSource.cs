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
	/// Represents the DataRepository.TongTienLuongTrongNamCuaGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TongTienLuongTrongNamCuaGiangVienDataSourceDesigner))]
	public class TongTienLuongTrongNamCuaGiangVienDataSource : ProviderDataSource<TongTienLuongTrongNamCuaGiangVien, TongTienLuongTrongNamCuaGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienDataSource class.
		/// </summary>
		public TongTienLuongTrongNamCuaGiangVienDataSource() : base(new TongTienLuongTrongNamCuaGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TongTienLuongTrongNamCuaGiangVienDataSourceView used by the TongTienLuongTrongNamCuaGiangVienDataSource.
		/// </summary>
		protected TongTienLuongTrongNamCuaGiangVienDataSourceView TongTienLuongTrongNamCuaGiangVienView
		{
			get { return ( View as TongTienLuongTrongNamCuaGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TongTienLuongTrongNamCuaGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public TongTienLuongTrongNamCuaGiangVienSelectMethod SelectMethod
		{
			get
			{
				TongTienLuongTrongNamCuaGiangVienSelectMethod selectMethod = TongTienLuongTrongNamCuaGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TongTienLuongTrongNamCuaGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TongTienLuongTrongNamCuaGiangVienDataSourceView class that is to be
		/// used by the TongTienLuongTrongNamCuaGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the TongTienLuongTrongNamCuaGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<TongTienLuongTrongNamCuaGiangVien, TongTienLuongTrongNamCuaGiangVienKey> GetNewDataSourceView()
		{
			return new TongTienLuongTrongNamCuaGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the TongTienLuongTrongNamCuaGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TongTienLuongTrongNamCuaGiangVienDataSourceView : ProviderDataSourceView<TongTienLuongTrongNamCuaGiangVien, TongTienLuongTrongNamCuaGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TongTienLuongTrongNamCuaGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TongTienLuongTrongNamCuaGiangVienDataSourceView(TongTienLuongTrongNamCuaGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TongTienLuongTrongNamCuaGiangVienDataSource TongTienLuongTrongNamCuaGiangVienOwner
		{
			get { return Owner as TongTienLuongTrongNamCuaGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TongTienLuongTrongNamCuaGiangVienSelectMethod SelectMethod
		{
			get { return TongTienLuongTrongNamCuaGiangVienOwner.SelectMethod; }
			set { TongTienLuongTrongNamCuaGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TongTienLuongTrongNamCuaGiangVienService TongTienLuongTrongNamCuaGiangVienProvider
		{
			get { return Provider as TongTienLuongTrongNamCuaGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TongTienLuongTrongNamCuaGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TongTienLuongTrongNamCuaGiangVien> results = null;
			TongTienLuongTrongNamCuaGiangVien item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case TongTienLuongTrongNamCuaGiangVienSelectMethod.Get:
					TongTienLuongTrongNamCuaGiangVienKey entityKey  = new TongTienLuongTrongNamCuaGiangVienKey();
					entityKey.Load(values);
					item = TongTienLuongTrongNamCuaGiangVienProvider.Get(entityKey);
					results = new TList<TongTienLuongTrongNamCuaGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TongTienLuongTrongNamCuaGiangVienSelectMethod.GetAll:
                    results = TongTienLuongTrongNamCuaGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TongTienLuongTrongNamCuaGiangVienSelectMethod.GetPaged:
					results = TongTienLuongTrongNamCuaGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TongTienLuongTrongNamCuaGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = TongTienLuongTrongNamCuaGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TongTienLuongTrongNamCuaGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TongTienLuongTrongNamCuaGiangVienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = TongTienLuongTrongNamCuaGiangVienProvider.GetById(_id);
					results = new TList<TongTienLuongTrongNamCuaGiangVien>();
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
			if ( SelectMethod == TongTienLuongTrongNamCuaGiangVienSelectMethod.Get || SelectMethod == TongTienLuongTrongNamCuaGiangVienSelectMethod.GetById )
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
				TongTienLuongTrongNamCuaGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TongTienLuongTrongNamCuaGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TongTienLuongTrongNamCuaGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TongTienLuongTrongNamCuaGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TongTienLuongTrongNamCuaGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TongTienLuongTrongNamCuaGiangVienDataSource class.
	/// </summary>
	public class TongTienLuongTrongNamCuaGiangVienDataSourceDesigner : ProviderDataSourceDesigner<TongTienLuongTrongNamCuaGiangVien, TongTienLuongTrongNamCuaGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienDataSourceDesigner class.
		/// </summary>
		public TongTienLuongTrongNamCuaGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TongTienLuongTrongNamCuaGiangVienSelectMethod SelectMethod
		{
			get { return ((TongTienLuongTrongNamCuaGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TongTienLuongTrongNamCuaGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TongTienLuongTrongNamCuaGiangVienDataSourceActionList

	/// <summary>
	/// Supports the TongTienLuongTrongNamCuaGiangVienDataSourceDesigner class.
	/// </summary>
	internal class TongTienLuongTrongNamCuaGiangVienDataSourceActionList : DesignerActionList
	{
		private TongTienLuongTrongNamCuaGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TongTienLuongTrongNamCuaGiangVienDataSourceActionList(TongTienLuongTrongNamCuaGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TongTienLuongTrongNamCuaGiangVienSelectMethod SelectMethod
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

	#endregion TongTienLuongTrongNamCuaGiangVienDataSourceActionList
	
	#endregion TongTienLuongTrongNamCuaGiangVienDataSourceDesigner
	
	#region TongTienLuongTrongNamCuaGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TongTienLuongTrongNamCuaGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum TongTienLuongTrongNamCuaGiangVienSelectMethod
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
	
	#endregion TongTienLuongTrongNamCuaGiangVienSelectMethod

	#region TongTienLuongTrongNamCuaGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TongTienLuongTrongNamCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TongTienLuongTrongNamCuaGiangVienFilter : SqlFilter<TongTienLuongTrongNamCuaGiangVienColumn>
	{
	}
	
	#endregion TongTienLuongTrongNamCuaGiangVienFilter

	#region TongTienLuongTrongNamCuaGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TongTienLuongTrongNamCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TongTienLuongTrongNamCuaGiangVienExpressionBuilder : SqlExpressionBuilder<TongTienLuongTrongNamCuaGiangVienColumn>
	{
	}
	
	#endregion TongTienLuongTrongNamCuaGiangVienExpressionBuilder	

	#region TongTienLuongTrongNamCuaGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TongTienLuongTrongNamCuaGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TongTienLuongTrongNamCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TongTienLuongTrongNamCuaGiangVienProperty : ChildEntityProperty<TongTienLuongTrongNamCuaGiangVienChildEntityTypes>
	{
	}
	
	#endregion TongTienLuongTrongNamCuaGiangVienProperty
}

