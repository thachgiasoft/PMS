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
	/// Represents the DataRepository.SdhPhanLoaiHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhPhanLoaiHocPhanDataSourceDesigner))]
	public class SdhPhanLoaiHocPhanDataSource : ProviderDataSource<SdhPhanLoaiHocPhan, SdhPhanLoaiHocPhanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhPhanLoaiHocPhanDataSource class.
		/// </summary>
		public SdhPhanLoaiHocPhanDataSource() : base(new SdhPhanLoaiHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhPhanLoaiHocPhanDataSourceView used by the SdhPhanLoaiHocPhanDataSource.
		/// </summary>
		protected SdhPhanLoaiHocPhanDataSourceView SdhPhanLoaiHocPhanView
		{
			get { return ( View as SdhPhanLoaiHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhPhanLoaiHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public SdhPhanLoaiHocPhanSelectMethod SelectMethod
		{
			get
			{
				SdhPhanLoaiHocPhanSelectMethod selectMethod = SdhPhanLoaiHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhPhanLoaiHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhPhanLoaiHocPhanDataSourceView class that is to be
		/// used by the SdhPhanLoaiHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the SdhPhanLoaiHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhPhanLoaiHocPhan, SdhPhanLoaiHocPhanKey> GetNewDataSourceView()
		{
			return new SdhPhanLoaiHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhPhanLoaiHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhPhanLoaiHocPhanDataSourceView : ProviderDataSourceView<SdhPhanLoaiHocPhan, SdhPhanLoaiHocPhanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhPhanLoaiHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhPhanLoaiHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhPhanLoaiHocPhanDataSourceView(SdhPhanLoaiHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhPhanLoaiHocPhanDataSource SdhPhanLoaiHocPhanOwner
		{
			get { return Owner as SdhPhanLoaiHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhPhanLoaiHocPhanSelectMethod SelectMethod
		{
			get { return SdhPhanLoaiHocPhanOwner.SelectMethod; }
			set { SdhPhanLoaiHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhPhanLoaiHocPhanService SdhPhanLoaiHocPhanProvider
		{
			get { return Provider as SdhPhanLoaiHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhPhanLoaiHocPhan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhPhanLoaiHocPhan> results = null;
			SdhPhanLoaiHocPhan item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case SdhPhanLoaiHocPhanSelectMethod.Get:
					SdhPhanLoaiHocPhanKey entityKey  = new SdhPhanLoaiHocPhanKey();
					entityKey.Load(values);
					item = SdhPhanLoaiHocPhanProvider.Get(entityKey);
					results = new TList<SdhPhanLoaiHocPhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhPhanLoaiHocPhanSelectMethod.GetAll:
                    results = SdhPhanLoaiHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhPhanLoaiHocPhanSelectMethod.GetPaged:
					results = SdhPhanLoaiHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhPhanLoaiHocPhanSelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhPhanLoaiHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhPhanLoaiHocPhanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhPhanLoaiHocPhanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SdhPhanLoaiHocPhanProvider.GetById(_id);
					results = new TList<SdhPhanLoaiHocPhan>();
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
			if ( SelectMethod == SdhPhanLoaiHocPhanSelectMethod.Get || SelectMethod == SdhPhanLoaiHocPhanSelectMethod.GetById )
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
				SdhPhanLoaiHocPhan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhPhanLoaiHocPhanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhPhanLoaiHocPhan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhPhanLoaiHocPhanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhPhanLoaiHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhPhanLoaiHocPhanDataSource class.
	/// </summary>
	public class SdhPhanLoaiHocPhanDataSourceDesigner : ProviderDataSourceDesigner<SdhPhanLoaiHocPhan, SdhPhanLoaiHocPhanKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhPhanLoaiHocPhanDataSourceDesigner class.
		/// </summary>
		public SdhPhanLoaiHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhPhanLoaiHocPhanSelectMethod SelectMethod
		{
			get { return ((SdhPhanLoaiHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhPhanLoaiHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhPhanLoaiHocPhanDataSourceActionList

	/// <summary>
	/// Supports the SdhPhanLoaiHocPhanDataSourceDesigner class.
	/// </summary>
	internal class SdhPhanLoaiHocPhanDataSourceActionList : DesignerActionList
	{
		private SdhPhanLoaiHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhPhanLoaiHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhPhanLoaiHocPhanDataSourceActionList(SdhPhanLoaiHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhPhanLoaiHocPhanSelectMethod SelectMethod
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

	#endregion SdhPhanLoaiHocPhanDataSourceActionList
	
	#endregion SdhPhanLoaiHocPhanDataSourceDesigner
	
	#region SdhPhanLoaiHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhPhanLoaiHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum SdhPhanLoaiHocPhanSelectMethod
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
	
	#endregion SdhPhanLoaiHocPhanSelectMethod

	#region SdhPhanLoaiHocPhanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhPhanLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhPhanLoaiHocPhanFilter : SqlFilter<SdhPhanLoaiHocPhanColumn>
	{
	}
	
	#endregion SdhPhanLoaiHocPhanFilter

	#region SdhPhanLoaiHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhPhanLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhPhanLoaiHocPhanExpressionBuilder : SqlExpressionBuilder<SdhPhanLoaiHocPhanColumn>
	{
	}
	
	#endregion SdhPhanLoaiHocPhanExpressionBuilder	

	#region SdhPhanLoaiHocPhanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhPhanLoaiHocPhanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhPhanLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhPhanLoaiHocPhanProperty : ChildEntityProperty<SdhPhanLoaiHocPhanChildEntityTypes>
	{
	}
	
	#endregion SdhPhanLoaiHocPhanProperty
}

