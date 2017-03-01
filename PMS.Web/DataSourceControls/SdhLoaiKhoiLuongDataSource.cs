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
	/// Represents the DataRepository.SdhLoaiKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhLoaiKhoiLuongDataSourceDesigner))]
	public class SdhLoaiKhoiLuongDataSource : ProviderDataSource<SdhLoaiKhoiLuong, SdhLoaiKhoiLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongDataSource class.
		/// </summary>
		public SdhLoaiKhoiLuongDataSource() : base(new SdhLoaiKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhLoaiKhoiLuongDataSourceView used by the SdhLoaiKhoiLuongDataSource.
		/// </summary>
		protected SdhLoaiKhoiLuongDataSourceView SdhLoaiKhoiLuongView
		{
			get { return ( View as SdhLoaiKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhLoaiKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public SdhLoaiKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				SdhLoaiKhoiLuongSelectMethod selectMethod = SdhLoaiKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhLoaiKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhLoaiKhoiLuongDataSourceView class that is to be
		/// used by the SdhLoaiKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the SdhLoaiKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhLoaiKhoiLuong, SdhLoaiKhoiLuongKey> GetNewDataSourceView()
		{
			return new SdhLoaiKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhLoaiKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhLoaiKhoiLuongDataSourceView : ProviderDataSourceView<SdhLoaiKhoiLuong, SdhLoaiKhoiLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhLoaiKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhLoaiKhoiLuongDataSourceView(SdhLoaiKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhLoaiKhoiLuongDataSource SdhLoaiKhoiLuongOwner
		{
			get { return Owner as SdhLoaiKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhLoaiKhoiLuongSelectMethod SelectMethod
		{
			get { return SdhLoaiKhoiLuongOwner.SelectMethod; }
			set { SdhLoaiKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhLoaiKhoiLuongService SdhLoaiKhoiLuongProvider
		{
			get { return Provider as SdhLoaiKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhLoaiKhoiLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhLoaiKhoiLuong> results = null;
			SdhLoaiKhoiLuong item;
			count = 0;
			
			System.String _maLoaiKhoiLuong;

			switch ( SelectMethod )
			{
				case SdhLoaiKhoiLuongSelectMethod.Get:
					SdhLoaiKhoiLuongKey entityKey  = new SdhLoaiKhoiLuongKey();
					entityKey.Load(values);
					item = SdhLoaiKhoiLuongProvider.Get(entityKey);
					results = new TList<SdhLoaiKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhLoaiKhoiLuongSelectMethod.GetAll:
                    results = SdhLoaiKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhLoaiKhoiLuongSelectMethod.GetPaged:
					results = SdhLoaiKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhLoaiKhoiLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhLoaiKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhLoaiKhoiLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhLoaiKhoiLuongSelectMethod.GetByMaLoaiKhoiLuong:
					_maLoaiKhoiLuong = ( values["MaLoaiKhoiLuong"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLoaiKhoiLuong"], typeof(System.String)) : string.Empty;
					item = SdhLoaiKhoiLuongProvider.GetByMaLoaiKhoiLuong(_maLoaiKhoiLuong);
					results = new TList<SdhLoaiKhoiLuong>();
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
			if ( SelectMethod == SdhLoaiKhoiLuongSelectMethod.Get || SelectMethod == SdhLoaiKhoiLuongSelectMethod.GetByMaLoaiKhoiLuong )
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
				SdhLoaiKhoiLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhLoaiKhoiLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhLoaiKhoiLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhLoaiKhoiLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhLoaiKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhLoaiKhoiLuongDataSource class.
	/// </summary>
	public class SdhLoaiKhoiLuongDataSourceDesigner : ProviderDataSourceDesigner<SdhLoaiKhoiLuong, SdhLoaiKhoiLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongDataSourceDesigner class.
		/// </summary>
		public SdhLoaiKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhLoaiKhoiLuongSelectMethod SelectMethod
		{
			get { return ((SdhLoaiKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhLoaiKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhLoaiKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the SdhLoaiKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class SdhLoaiKhoiLuongDataSourceActionList : DesignerActionList
	{
		private SdhLoaiKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhLoaiKhoiLuongDataSourceActionList(SdhLoaiKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhLoaiKhoiLuongSelectMethod SelectMethod
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

	#endregion SdhLoaiKhoiLuongDataSourceActionList
	
	#endregion SdhLoaiKhoiLuongDataSourceDesigner
	
	#region SdhLoaiKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhLoaiKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum SdhLoaiKhoiLuongSelectMethod
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
		/// Represents the GetByMaLoaiKhoiLuong method.
		/// </summary>
		GetByMaLoaiKhoiLuong
	}
	
	#endregion SdhLoaiKhoiLuongSelectMethod

	#region SdhLoaiKhoiLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhLoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhLoaiKhoiLuongFilter : SqlFilter<SdhLoaiKhoiLuongColumn>
	{
	}
	
	#endregion SdhLoaiKhoiLuongFilter

	#region SdhLoaiKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhLoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhLoaiKhoiLuongExpressionBuilder : SqlExpressionBuilder<SdhLoaiKhoiLuongColumn>
	{
	}
	
	#endregion SdhLoaiKhoiLuongExpressionBuilder	

	#region SdhLoaiKhoiLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhLoaiKhoiLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhLoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhLoaiKhoiLuongProperty : ChildEntityProperty<SdhLoaiKhoiLuongChildEntityTypes>
	{
	}
	
	#endregion SdhLoaiKhoiLuongProperty
}

