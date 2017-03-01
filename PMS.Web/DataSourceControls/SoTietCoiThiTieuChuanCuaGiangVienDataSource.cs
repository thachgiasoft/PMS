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
	/// Represents the DataRepository.SoTietCoiThiTieuChuanCuaGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner))]
	public class SoTietCoiThiTieuChuanCuaGiangVienDataSource : ProviderDataSource<SoTietCoiThiTieuChuanCuaGiangVien, SoTietCoiThiTieuChuanCuaGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SoTietCoiThiTieuChuanCuaGiangVienDataSource class.
		/// </summary>
		public SoTietCoiThiTieuChuanCuaGiangVienDataSource() : base(new SoTietCoiThiTieuChuanCuaGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SoTietCoiThiTieuChuanCuaGiangVienDataSourceView used by the SoTietCoiThiTieuChuanCuaGiangVienDataSource.
		/// </summary>
		protected SoTietCoiThiTieuChuanCuaGiangVienDataSourceView SoTietCoiThiTieuChuanCuaGiangVienView
		{
			get { return ( View as SoTietCoiThiTieuChuanCuaGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SoTietCoiThiTieuChuanCuaGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public SoTietCoiThiTieuChuanCuaGiangVienSelectMethod SelectMethod
		{
			get
			{
				SoTietCoiThiTieuChuanCuaGiangVienSelectMethod selectMethod = SoTietCoiThiTieuChuanCuaGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SoTietCoiThiTieuChuanCuaGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SoTietCoiThiTieuChuanCuaGiangVienDataSourceView class that is to be
		/// used by the SoTietCoiThiTieuChuanCuaGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the SoTietCoiThiTieuChuanCuaGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<SoTietCoiThiTieuChuanCuaGiangVien, SoTietCoiThiTieuChuanCuaGiangVienKey> GetNewDataSourceView()
		{
			return new SoTietCoiThiTieuChuanCuaGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the SoTietCoiThiTieuChuanCuaGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SoTietCoiThiTieuChuanCuaGiangVienDataSourceView : ProviderDataSourceView<SoTietCoiThiTieuChuanCuaGiangVien, SoTietCoiThiTieuChuanCuaGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SoTietCoiThiTieuChuanCuaGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SoTietCoiThiTieuChuanCuaGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SoTietCoiThiTieuChuanCuaGiangVienDataSourceView(SoTietCoiThiTieuChuanCuaGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SoTietCoiThiTieuChuanCuaGiangVienDataSource SoTietCoiThiTieuChuanCuaGiangVienOwner
		{
			get { return Owner as SoTietCoiThiTieuChuanCuaGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SoTietCoiThiTieuChuanCuaGiangVienSelectMethod SelectMethod
		{
			get { return SoTietCoiThiTieuChuanCuaGiangVienOwner.SelectMethod; }
			set { SoTietCoiThiTieuChuanCuaGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SoTietCoiThiTieuChuanCuaGiangVienService SoTietCoiThiTieuChuanCuaGiangVienProvider
		{
			get { return Provider as SoTietCoiThiTieuChuanCuaGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SoTietCoiThiTieuChuanCuaGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SoTietCoiThiTieuChuanCuaGiangVien> results = null;
			SoTietCoiThiTieuChuanCuaGiangVien item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case SoTietCoiThiTieuChuanCuaGiangVienSelectMethod.Get:
					SoTietCoiThiTieuChuanCuaGiangVienKey entityKey  = new SoTietCoiThiTieuChuanCuaGiangVienKey();
					entityKey.Load(values);
					item = SoTietCoiThiTieuChuanCuaGiangVienProvider.Get(entityKey);
					results = new TList<SoTietCoiThiTieuChuanCuaGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SoTietCoiThiTieuChuanCuaGiangVienSelectMethod.GetAll:
                    results = SoTietCoiThiTieuChuanCuaGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SoTietCoiThiTieuChuanCuaGiangVienSelectMethod.GetPaged:
					results = SoTietCoiThiTieuChuanCuaGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SoTietCoiThiTieuChuanCuaGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = SoTietCoiThiTieuChuanCuaGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SoTietCoiThiTieuChuanCuaGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SoTietCoiThiTieuChuanCuaGiangVienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SoTietCoiThiTieuChuanCuaGiangVienProvider.GetById(_id);
					results = new TList<SoTietCoiThiTieuChuanCuaGiangVien>();
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
			if ( SelectMethod == SoTietCoiThiTieuChuanCuaGiangVienSelectMethod.Get || SelectMethod == SoTietCoiThiTieuChuanCuaGiangVienSelectMethod.GetById )
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
				SoTietCoiThiTieuChuanCuaGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SoTietCoiThiTieuChuanCuaGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SoTietCoiThiTieuChuanCuaGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SoTietCoiThiTieuChuanCuaGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SoTietCoiThiTieuChuanCuaGiangVienDataSource class.
	/// </summary>
	public class SoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner : ProviderDataSourceDesigner<SoTietCoiThiTieuChuanCuaGiangVien, SoTietCoiThiTieuChuanCuaGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the SoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner class.
		/// </summary>
		public SoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SoTietCoiThiTieuChuanCuaGiangVienSelectMethod SelectMethod
		{
			get { return ((SoTietCoiThiTieuChuanCuaGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList

	/// <summary>
	/// Supports the SoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner class.
	/// </summary>
	internal class SoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList : DesignerActionList
	{
		private SoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList(SoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SoTietCoiThiTieuChuanCuaGiangVienSelectMethod SelectMethod
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

	#endregion SoTietCoiThiTieuChuanCuaGiangVienDataSourceActionList
	
	#endregion SoTietCoiThiTieuChuanCuaGiangVienDataSourceDesigner
	
	#region SoTietCoiThiTieuChuanCuaGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SoTietCoiThiTieuChuanCuaGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum SoTietCoiThiTieuChuanCuaGiangVienSelectMethod
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
	
	#endregion SoTietCoiThiTieuChuanCuaGiangVienSelectMethod

	#region SoTietCoiThiTieuChuanCuaGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SoTietCoiThiTieuChuanCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SoTietCoiThiTieuChuanCuaGiangVienFilter : SqlFilter<SoTietCoiThiTieuChuanCuaGiangVienColumn>
	{
	}
	
	#endregion SoTietCoiThiTieuChuanCuaGiangVienFilter

	#region SoTietCoiThiTieuChuanCuaGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SoTietCoiThiTieuChuanCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SoTietCoiThiTieuChuanCuaGiangVienExpressionBuilder : SqlExpressionBuilder<SoTietCoiThiTieuChuanCuaGiangVienColumn>
	{
	}
	
	#endregion SoTietCoiThiTieuChuanCuaGiangVienExpressionBuilder	

	#region SoTietCoiThiTieuChuanCuaGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SoTietCoiThiTieuChuanCuaGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SoTietCoiThiTieuChuanCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SoTietCoiThiTieuChuanCuaGiangVienProperty : ChildEntityProperty<SoTietCoiThiTieuChuanCuaGiangVienChildEntityTypes>
	{
	}
	
	#endregion SoTietCoiThiTieuChuanCuaGiangVienProperty
}

