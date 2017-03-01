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
	/// Represents the DataRepository.ThanhTraChamGiangTheoKhoaHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThanhTraChamGiangTheoKhoaHocDataSourceDesigner))]
	public class ThanhTraChamGiangTheoKhoaHocDataSource : ProviderDataSource<ThanhTraChamGiangTheoKhoaHoc, ThanhTraChamGiangTheoKhoaHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocDataSource class.
		/// </summary>
		public ThanhTraChamGiangTheoKhoaHocDataSource() : base(new ThanhTraChamGiangTheoKhoaHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThanhTraChamGiangTheoKhoaHocDataSourceView used by the ThanhTraChamGiangTheoKhoaHocDataSource.
		/// </summary>
		protected ThanhTraChamGiangTheoKhoaHocDataSourceView ThanhTraChamGiangTheoKhoaHocView
		{
			get { return ( View as ThanhTraChamGiangTheoKhoaHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThanhTraChamGiangTheoKhoaHocDataSource control invokes to retrieve data.
		/// </summary>
		public ThanhTraChamGiangTheoKhoaHocSelectMethod SelectMethod
		{
			get
			{
				ThanhTraChamGiangTheoKhoaHocSelectMethod selectMethod = ThanhTraChamGiangTheoKhoaHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThanhTraChamGiangTheoKhoaHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThanhTraChamGiangTheoKhoaHocDataSourceView class that is to be
		/// used by the ThanhTraChamGiangTheoKhoaHocDataSource.
		/// </summary>
		/// <returns>An instance of the ThanhTraChamGiangTheoKhoaHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ThanhTraChamGiangTheoKhoaHoc, ThanhTraChamGiangTheoKhoaHocKey> GetNewDataSourceView()
		{
			return new ThanhTraChamGiangTheoKhoaHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ThanhTraChamGiangTheoKhoaHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThanhTraChamGiangTheoKhoaHocDataSourceView : ProviderDataSourceView<ThanhTraChamGiangTheoKhoaHoc, ThanhTraChamGiangTheoKhoaHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThanhTraChamGiangTheoKhoaHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThanhTraChamGiangTheoKhoaHocDataSourceView(ThanhTraChamGiangTheoKhoaHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThanhTraChamGiangTheoKhoaHocDataSource ThanhTraChamGiangTheoKhoaHocOwner
		{
			get { return Owner as ThanhTraChamGiangTheoKhoaHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThanhTraChamGiangTheoKhoaHocSelectMethod SelectMethod
		{
			get { return ThanhTraChamGiangTheoKhoaHocOwner.SelectMethod; }
			set { ThanhTraChamGiangTheoKhoaHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThanhTraChamGiangTheoKhoaHocService ThanhTraChamGiangTheoKhoaHocProvider
		{
			get { return Provider as ThanhTraChamGiangTheoKhoaHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThanhTraChamGiangTheoKhoaHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThanhTraChamGiangTheoKhoaHoc> results = null;
			ThanhTraChamGiangTheoKhoaHoc item;
			count = 0;
			
			System.String _namHoc;
			System.String _hocKy;
			System.String _maKhoaHoc;

			switch ( SelectMethod )
			{
				case ThanhTraChamGiangTheoKhoaHocSelectMethod.Get:
					ThanhTraChamGiangTheoKhoaHocKey entityKey  = new ThanhTraChamGiangTheoKhoaHocKey();
					entityKey.Load(values);
					item = ThanhTraChamGiangTheoKhoaHocProvider.Get(entityKey);
					results = new TList<ThanhTraChamGiangTheoKhoaHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThanhTraChamGiangTheoKhoaHocSelectMethod.GetAll:
                    results = ThanhTraChamGiangTheoKhoaHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThanhTraChamGiangTheoKhoaHocSelectMethod.GetPaged:
					results = ThanhTraChamGiangTheoKhoaHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThanhTraChamGiangTheoKhoaHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThanhTraChamGiangTheoKhoaHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThanhTraChamGiangTheoKhoaHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThanhTraChamGiangTheoKhoaHocSelectMethod.GetByNamHocHocKyMaKhoaHoc:
					_namHoc = ( values["NamHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String)) : string.Empty;
					_hocKy = ( values["HocKy"] != null ) ? (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String)) : string.Empty;
					_maKhoaHoc = ( values["MaKhoaHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaKhoaHoc"], typeof(System.String)) : string.Empty;
					item = ThanhTraChamGiangTheoKhoaHocProvider.GetByNamHocHocKyMaKhoaHoc(_namHoc, _hocKy, _maKhoaHoc);
					results = new TList<ThanhTraChamGiangTheoKhoaHoc>();
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
			if ( SelectMethod == ThanhTraChamGiangTheoKhoaHocSelectMethod.Get || SelectMethod == ThanhTraChamGiangTheoKhoaHocSelectMethod.GetByNamHocHocKyMaKhoaHoc )
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
				ThanhTraChamGiangTheoKhoaHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThanhTraChamGiangTheoKhoaHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThanhTraChamGiangTheoKhoaHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThanhTraChamGiangTheoKhoaHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThanhTraChamGiangTheoKhoaHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThanhTraChamGiangTheoKhoaHocDataSource class.
	/// </summary>
	public class ThanhTraChamGiangTheoKhoaHocDataSourceDesigner : ProviderDataSourceDesigner<ThanhTraChamGiangTheoKhoaHoc, ThanhTraChamGiangTheoKhoaHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocDataSourceDesigner class.
		/// </summary>
		public ThanhTraChamGiangTheoKhoaHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhTraChamGiangTheoKhoaHocSelectMethod SelectMethod
		{
			get { return ((ThanhTraChamGiangTheoKhoaHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThanhTraChamGiangTheoKhoaHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThanhTraChamGiangTheoKhoaHocDataSourceActionList

	/// <summary>
	/// Supports the ThanhTraChamGiangTheoKhoaHocDataSourceDesigner class.
	/// </summary>
	internal class ThanhTraChamGiangTheoKhoaHocDataSourceActionList : DesignerActionList
	{
		private ThanhTraChamGiangTheoKhoaHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThanhTraChamGiangTheoKhoaHocDataSourceActionList(ThanhTraChamGiangTheoKhoaHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhTraChamGiangTheoKhoaHocSelectMethod SelectMethod
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

	#endregion ThanhTraChamGiangTheoKhoaHocDataSourceActionList
	
	#endregion ThanhTraChamGiangTheoKhoaHocDataSourceDesigner
	
	#region ThanhTraChamGiangTheoKhoaHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThanhTraChamGiangTheoKhoaHocDataSource.SelectMethod property.
	/// </summary>
	public enum ThanhTraChamGiangTheoKhoaHocSelectMethod
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
		/// Represents the GetByNamHocHocKyMaKhoaHoc method.
		/// </summary>
		GetByNamHocHocKyMaKhoaHoc
	}
	
	#endregion ThanhTraChamGiangTheoKhoaHocSelectMethod

	#region ThanhTraChamGiangTheoKhoaHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraChamGiangTheoKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraChamGiangTheoKhoaHocFilter : SqlFilter<ThanhTraChamGiangTheoKhoaHocColumn>
	{
	}
	
	#endregion ThanhTraChamGiangTheoKhoaHocFilter

	#region ThanhTraChamGiangTheoKhoaHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraChamGiangTheoKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraChamGiangTheoKhoaHocExpressionBuilder : SqlExpressionBuilder<ThanhTraChamGiangTheoKhoaHocColumn>
	{
	}
	
	#endregion ThanhTraChamGiangTheoKhoaHocExpressionBuilder	

	#region ThanhTraChamGiangTheoKhoaHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThanhTraChamGiangTheoKhoaHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraChamGiangTheoKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraChamGiangTheoKhoaHocProperty : ChildEntityProperty<ThanhTraChamGiangTheoKhoaHocChildEntityTypes>
	{
	}
	
	#endregion ThanhTraChamGiangTheoKhoaHocProperty
}

