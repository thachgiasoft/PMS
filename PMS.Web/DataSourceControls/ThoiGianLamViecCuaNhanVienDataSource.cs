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
	/// Represents the DataRepository.ThoiGianLamViecCuaNhanVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThoiGianLamViecCuaNhanVienDataSourceDesigner))]
	public class ThoiGianLamViecCuaNhanVienDataSource : ProviderDataSource<ThoiGianLamViecCuaNhanVien, ThoiGianLamViecCuaNhanVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienDataSource class.
		/// </summary>
		public ThoiGianLamViecCuaNhanVienDataSource() : base(new ThoiGianLamViecCuaNhanVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThoiGianLamViecCuaNhanVienDataSourceView used by the ThoiGianLamViecCuaNhanVienDataSource.
		/// </summary>
		protected ThoiGianLamViecCuaNhanVienDataSourceView ThoiGianLamViecCuaNhanVienView
		{
			get { return ( View as ThoiGianLamViecCuaNhanVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThoiGianLamViecCuaNhanVienDataSource control invokes to retrieve data.
		/// </summary>
		public ThoiGianLamViecCuaNhanVienSelectMethod SelectMethod
		{
			get
			{
				ThoiGianLamViecCuaNhanVienSelectMethod selectMethod = ThoiGianLamViecCuaNhanVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThoiGianLamViecCuaNhanVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThoiGianLamViecCuaNhanVienDataSourceView class that is to be
		/// used by the ThoiGianLamViecCuaNhanVienDataSource.
		/// </summary>
		/// <returns>An instance of the ThoiGianLamViecCuaNhanVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ThoiGianLamViecCuaNhanVien, ThoiGianLamViecCuaNhanVienKey> GetNewDataSourceView()
		{
			return new ThoiGianLamViecCuaNhanVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ThoiGianLamViecCuaNhanVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThoiGianLamViecCuaNhanVienDataSourceView : ProviderDataSourceView<ThoiGianLamViecCuaNhanVien, ThoiGianLamViecCuaNhanVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThoiGianLamViecCuaNhanVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThoiGianLamViecCuaNhanVienDataSourceView(ThoiGianLamViecCuaNhanVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThoiGianLamViecCuaNhanVienDataSource ThoiGianLamViecCuaNhanVienOwner
		{
			get { return Owner as ThoiGianLamViecCuaNhanVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThoiGianLamViecCuaNhanVienSelectMethod SelectMethod
		{
			get { return ThoiGianLamViecCuaNhanVienOwner.SelectMethod; }
			set { ThoiGianLamViecCuaNhanVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThoiGianLamViecCuaNhanVienService ThoiGianLamViecCuaNhanVienProvider
		{
			get { return Provider as ThoiGianLamViecCuaNhanVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThoiGianLamViecCuaNhanVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThoiGianLamViecCuaNhanVien> results = null;
			ThoiGianLamViecCuaNhanVien item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maGiangVien_nullable;

			switch ( SelectMethod )
			{
				case ThoiGianLamViecCuaNhanVienSelectMethod.Get:
					ThoiGianLamViecCuaNhanVienKey entityKey  = new ThoiGianLamViecCuaNhanVienKey();
					entityKey.Load(values);
					item = ThoiGianLamViecCuaNhanVienProvider.Get(entityKey);
					results = new TList<ThoiGianLamViecCuaNhanVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThoiGianLamViecCuaNhanVienSelectMethod.GetAll:
                    results = ThoiGianLamViecCuaNhanVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThoiGianLamViecCuaNhanVienSelectMethod.GetPaged:
					results = ThoiGianLamViecCuaNhanVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThoiGianLamViecCuaNhanVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThoiGianLamViecCuaNhanVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThoiGianLamViecCuaNhanVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThoiGianLamViecCuaNhanVienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThoiGianLamViecCuaNhanVienProvider.GetById(_id);
					results = new TList<ThoiGianLamViecCuaNhanVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case ThoiGianLamViecCuaNhanVienSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = ThoiGianLamViecCuaNhanVienProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
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
			if ( SelectMethod == ThoiGianLamViecCuaNhanVienSelectMethod.Get || SelectMethod == ThoiGianLamViecCuaNhanVienSelectMethod.GetById )
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
				ThoiGianLamViecCuaNhanVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThoiGianLamViecCuaNhanVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThoiGianLamViecCuaNhanVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThoiGianLamViecCuaNhanVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThoiGianLamViecCuaNhanVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThoiGianLamViecCuaNhanVienDataSource class.
	/// </summary>
	public class ThoiGianLamViecCuaNhanVienDataSourceDesigner : ProviderDataSourceDesigner<ThoiGianLamViecCuaNhanVien, ThoiGianLamViecCuaNhanVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienDataSourceDesigner class.
		/// </summary>
		public ThoiGianLamViecCuaNhanVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThoiGianLamViecCuaNhanVienSelectMethod SelectMethod
		{
			get { return ((ThoiGianLamViecCuaNhanVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThoiGianLamViecCuaNhanVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThoiGianLamViecCuaNhanVienDataSourceActionList

	/// <summary>
	/// Supports the ThoiGianLamViecCuaNhanVienDataSourceDesigner class.
	/// </summary>
	internal class ThoiGianLamViecCuaNhanVienDataSourceActionList : DesignerActionList
	{
		private ThoiGianLamViecCuaNhanVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThoiGianLamViecCuaNhanVienDataSourceActionList(ThoiGianLamViecCuaNhanVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThoiGianLamViecCuaNhanVienSelectMethod SelectMethod
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

	#endregion ThoiGianLamViecCuaNhanVienDataSourceActionList
	
	#endregion ThoiGianLamViecCuaNhanVienDataSourceDesigner
	
	#region ThoiGianLamViecCuaNhanVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThoiGianLamViecCuaNhanVienDataSource.SelectMethod property.
	/// </summary>
	public enum ThoiGianLamViecCuaNhanVienSelectMethod
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
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion ThoiGianLamViecCuaNhanVienSelectMethod

	#region ThoiGianLamViecCuaNhanVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianLamViecCuaNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianLamViecCuaNhanVienFilter : SqlFilter<ThoiGianLamViecCuaNhanVienColumn>
	{
	}
	
	#endregion ThoiGianLamViecCuaNhanVienFilter

	#region ThoiGianLamViecCuaNhanVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianLamViecCuaNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianLamViecCuaNhanVienExpressionBuilder : SqlExpressionBuilder<ThoiGianLamViecCuaNhanVienColumn>
	{
	}
	
	#endregion ThoiGianLamViecCuaNhanVienExpressionBuilder	

	#region ThoiGianLamViecCuaNhanVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThoiGianLamViecCuaNhanVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianLamViecCuaNhanVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianLamViecCuaNhanVienProperty : ChildEntityProperty<ThoiGianLamViecCuaNhanVienChildEntityTypes>
	{
	}
	
	#endregion ThoiGianLamViecCuaNhanVienProperty
}

