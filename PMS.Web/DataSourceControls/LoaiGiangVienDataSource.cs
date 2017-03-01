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
	/// Represents the DataRepository.LoaiGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LoaiGiangVienDataSourceDesigner))]
	public class LoaiGiangVienDataSource : ProviderDataSource<LoaiGiangVien, LoaiGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienDataSource class.
		/// </summary>
		public LoaiGiangVienDataSource() : base(new LoaiGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LoaiGiangVienDataSourceView used by the LoaiGiangVienDataSource.
		/// </summary>
		protected LoaiGiangVienDataSourceView LoaiGiangVienView
		{
			get { return ( View as LoaiGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LoaiGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public LoaiGiangVienSelectMethod SelectMethod
		{
			get
			{
				LoaiGiangVienSelectMethod selectMethod = LoaiGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LoaiGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LoaiGiangVienDataSourceView class that is to be
		/// used by the LoaiGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the LoaiGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<LoaiGiangVien, LoaiGiangVienKey> GetNewDataSourceView()
		{
			return new LoaiGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the LoaiGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LoaiGiangVienDataSourceView : ProviderDataSourceView<LoaiGiangVien, LoaiGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LoaiGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LoaiGiangVienDataSourceView(LoaiGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LoaiGiangVienDataSource LoaiGiangVienOwner
		{
			get { return Owner as LoaiGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LoaiGiangVienSelectMethod SelectMethod
		{
			get { return LoaiGiangVienOwner.SelectMethod; }
			set { LoaiGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LoaiGiangVienService LoaiGiangVienProvider
		{
			get { return Provider as LoaiGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LoaiGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LoaiGiangVien> results = null;
			LoaiGiangVien item;
			count = 0;
			
			System.String _maQuanLy;
			System.Int32 _maLoaiGiangVien;

			switch ( SelectMethod )
			{
				case LoaiGiangVienSelectMethod.Get:
					LoaiGiangVienKey entityKey  = new LoaiGiangVienKey();
					entityKey.Load(values);
					item = LoaiGiangVienProvider.Get(entityKey);
					results = new TList<LoaiGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LoaiGiangVienSelectMethod.GetAll:
                    results = LoaiGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LoaiGiangVienSelectMethod.GetPaged:
					results = LoaiGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LoaiGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = LoaiGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LoaiGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LoaiGiangVienSelectMethod.GetByMaLoaiGiangVien:
					_maLoaiGiangVien = ( values["MaLoaiGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32)) : (int)0;
					item = LoaiGiangVienProvider.GetByMaLoaiGiangVien(_maLoaiGiangVien);
					results = new TList<LoaiGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case LoaiGiangVienSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String)) : string.Empty;
					item = LoaiGiangVienProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<LoaiGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				// M:M
				// Custom
				case LoaiGiangVienSelectMethod.LayLoaiGiangVienThongKe:
					results = LoaiGiangVienProvider.LayLoaiGiangVienThongKe(StartIndex, PageSize);
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
			if ( SelectMethod == LoaiGiangVienSelectMethod.Get || SelectMethod == LoaiGiangVienSelectMethod.GetByMaLoaiGiangVien )
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
				LoaiGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LoaiGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LoaiGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LoaiGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LoaiGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LoaiGiangVienDataSource class.
	/// </summary>
	public class LoaiGiangVienDataSourceDesigner : ProviderDataSourceDesigner<LoaiGiangVien, LoaiGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienDataSourceDesigner class.
		/// </summary>
		public LoaiGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiGiangVienSelectMethod SelectMethod
		{
			get { return ((LoaiGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LoaiGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LoaiGiangVienDataSourceActionList

	/// <summary>
	/// Supports the LoaiGiangVienDataSourceDesigner class.
	/// </summary>
	internal class LoaiGiangVienDataSourceActionList : DesignerActionList
	{
		private LoaiGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LoaiGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LoaiGiangVienDataSourceActionList(LoaiGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiGiangVienSelectMethod SelectMethod
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

	#endregion LoaiGiangVienDataSourceActionList
	
	#endregion LoaiGiangVienDataSourceDesigner
	
	#region LoaiGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LoaiGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum LoaiGiangVienSelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaLoaiGiangVien method.
		/// </summary>
		GetByMaLoaiGiangVien,
		/// <summary>
		/// Represents the LayLoaiGiangVienThongKe method.
		/// </summary>
		LayLoaiGiangVienThongKe
	}
	
	#endregion LoaiGiangVienSelectMethod

	#region LoaiGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiGiangVienFilter : SqlFilter<LoaiGiangVienColumn>
	{
	}
	
	#endregion LoaiGiangVienFilter

	#region LoaiGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiGiangVienExpressionBuilder : SqlExpressionBuilder<LoaiGiangVienColumn>
	{
	}
	
	#endregion LoaiGiangVienExpressionBuilder	

	#region LoaiGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LoaiGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiGiangVienProperty : ChildEntityProperty<LoaiGiangVienChildEntityTypes>
	{
	}
	
	#endregion LoaiGiangVienProperty
}

