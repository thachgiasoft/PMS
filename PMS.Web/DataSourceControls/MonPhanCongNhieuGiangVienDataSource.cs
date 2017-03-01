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
	/// Represents the DataRepository.MonPhanCongNhieuGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonPhanCongNhieuGiangVienDataSourceDesigner))]
	public class MonPhanCongNhieuGiangVienDataSource : ProviderDataSource<MonPhanCongNhieuGiangVien, MonPhanCongNhieuGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonPhanCongNhieuGiangVienDataSource class.
		/// </summary>
		public MonPhanCongNhieuGiangVienDataSource() : base(new MonPhanCongNhieuGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonPhanCongNhieuGiangVienDataSourceView used by the MonPhanCongNhieuGiangVienDataSource.
		/// </summary>
		protected MonPhanCongNhieuGiangVienDataSourceView MonPhanCongNhieuGiangVienView
		{
			get { return ( View as MonPhanCongNhieuGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonPhanCongNhieuGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public MonPhanCongNhieuGiangVienSelectMethod SelectMethod
		{
			get
			{
				MonPhanCongNhieuGiangVienSelectMethod selectMethod = MonPhanCongNhieuGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonPhanCongNhieuGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonPhanCongNhieuGiangVienDataSourceView class that is to be
		/// used by the MonPhanCongNhieuGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the MonPhanCongNhieuGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<MonPhanCongNhieuGiangVien, MonPhanCongNhieuGiangVienKey> GetNewDataSourceView()
		{
			return new MonPhanCongNhieuGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the MonPhanCongNhieuGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonPhanCongNhieuGiangVienDataSourceView : ProviderDataSourceView<MonPhanCongNhieuGiangVien, MonPhanCongNhieuGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonPhanCongNhieuGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonPhanCongNhieuGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonPhanCongNhieuGiangVienDataSourceView(MonPhanCongNhieuGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonPhanCongNhieuGiangVienDataSource MonPhanCongNhieuGiangVienOwner
		{
			get { return Owner as MonPhanCongNhieuGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonPhanCongNhieuGiangVienSelectMethod SelectMethod
		{
			get { return MonPhanCongNhieuGiangVienOwner.SelectMethod; }
			set { MonPhanCongNhieuGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonPhanCongNhieuGiangVienService MonPhanCongNhieuGiangVienProvider
		{
			get { return Provider as MonPhanCongNhieuGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonPhanCongNhieuGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonPhanCongNhieuGiangVien> results = null;
			MonPhanCongNhieuGiangVien item;
			count = 0;
			
			System.Int32 _id;
			System.String sp667_NamHoc;
			System.String sp667_HocKy;

			switch ( SelectMethod )
			{
				case MonPhanCongNhieuGiangVienSelectMethod.Get:
					MonPhanCongNhieuGiangVienKey entityKey  = new MonPhanCongNhieuGiangVienKey();
					entityKey.Load(values);
					item = MonPhanCongNhieuGiangVienProvider.Get(entityKey);
					results = new TList<MonPhanCongNhieuGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonPhanCongNhieuGiangVienSelectMethod.GetAll:
                    results = MonPhanCongNhieuGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonPhanCongNhieuGiangVienSelectMethod.GetPaged:
					results = MonPhanCongNhieuGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonPhanCongNhieuGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonPhanCongNhieuGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonPhanCongNhieuGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonPhanCongNhieuGiangVienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = MonPhanCongNhieuGiangVienProvider.GetById(_id);
					results = new TList<MonPhanCongNhieuGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case MonPhanCongNhieuGiangVienSelectMethod.GetByNamHocHocKy:
					sp667_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp667_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = MonPhanCongNhieuGiangVienProvider.GetByNamHocHocKy(sp667_NamHoc, sp667_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == MonPhanCongNhieuGiangVienSelectMethod.Get || SelectMethod == MonPhanCongNhieuGiangVienSelectMethod.GetById )
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
				MonPhanCongNhieuGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonPhanCongNhieuGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonPhanCongNhieuGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonPhanCongNhieuGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonPhanCongNhieuGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonPhanCongNhieuGiangVienDataSource class.
	/// </summary>
	public class MonPhanCongNhieuGiangVienDataSourceDesigner : ProviderDataSourceDesigner<MonPhanCongNhieuGiangVien, MonPhanCongNhieuGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonPhanCongNhieuGiangVienDataSourceDesigner class.
		/// </summary>
		public MonPhanCongNhieuGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonPhanCongNhieuGiangVienSelectMethod SelectMethod
		{
			get { return ((MonPhanCongNhieuGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonPhanCongNhieuGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonPhanCongNhieuGiangVienDataSourceActionList

	/// <summary>
	/// Supports the MonPhanCongNhieuGiangVienDataSourceDesigner class.
	/// </summary>
	internal class MonPhanCongNhieuGiangVienDataSourceActionList : DesignerActionList
	{
		private MonPhanCongNhieuGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonPhanCongNhieuGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonPhanCongNhieuGiangVienDataSourceActionList(MonPhanCongNhieuGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonPhanCongNhieuGiangVienSelectMethod SelectMethod
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

	#endregion MonPhanCongNhieuGiangVienDataSourceActionList
	
	#endregion MonPhanCongNhieuGiangVienDataSourceDesigner
	
	#region MonPhanCongNhieuGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonPhanCongNhieuGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum MonPhanCongNhieuGiangVienSelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion MonPhanCongNhieuGiangVienSelectMethod

	#region MonPhanCongNhieuGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonPhanCongNhieuGiangVienFilter : SqlFilter<MonPhanCongNhieuGiangVienColumn>
	{
	}
	
	#endregion MonPhanCongNhieuGiangVienFilter

	#region MonPhanCongNhieuGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonPhanCongNhieuGiangVienExpressionBuilder : SqlExpressionBuilder<MonPhanCongNhieuGiangVienColumn>
	{
	}
	
	#endregion MonPhanCongNhieuGiangVienExpressionBuilder	

	#region MonPhanCongNhieuGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonPhanCongNhieuGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonPhanCongNhieuGiangVienProperty : ChildEntityProperty<MonPhanCongNhieuGiangVienChildEntityTypes>
	{
	}
	
	#endregion MonPhanCongNhieuGiangVienProperty
}

