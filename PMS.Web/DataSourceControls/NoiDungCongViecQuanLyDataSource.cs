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
	/// Represents the DataRepository.NoiDungCongViecQuanLyProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NoiDungCongViecQuanLyDataSourceDesigner))]
	public class NoiDungCongViecQuanLyDataSource : ProviderDataSource<NoiDungCongViecQuanLy, NoiDungCongViecQuanLyKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyDataSource class.
		/// </summary>
		public NoiDungCongViecQuanLyDataSource() : base(new NoiDungCongViecQuanLyService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NoiDungCongViecQuanLyDataSourceView used by the NoiDungCongViecQuanLyDataSource.
		/// </summary>
		protected NoiDungCongViecQuanLyDataSourceView NoiDungCongViecQuanLyView
		{
			get { return ( View as NoiDungCongViecQuanLyDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NoiDungCongViecQuanLyDataSource control invokes to retrieve data.
		/// </summary>
		public NoiDungCongViecQuanLySelectMethod SelectMethod
		{
			get
			{
				NoiDungCongViecQuanLySelectMethod selectMethod = NoiDungCongViecQuanLySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NoiDungCongViecQuanLySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NoiDungCongViecQuanLyDataSourceView class that is to be
		/// used by the NoiDungCongViecQuanLyDataSource.
		/// </summary>
		/// <returns>An instance of the NoiDungCongViecQuanLyDataSourceView class.</returns>
		protected override BaseDataSourceView<NoiDungCongViecQuanLy, NoiDungCongViecQuanLyKey> GetNewDataSourceView()
		{
			return new NoiDungCongViecQuanLyDataSourceView(this, DefaultViewName);
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
	/// Supports the NoiDungCongViecQuanLyDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NoiDungCongViecQuanLyDataSourceView : ProviderDataSourceView<NoiDungCongViecQuanLy, NoiDungCongViecQuanLyKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NoiDungCongViecQuanLyDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NoiDungCongViecQuanLyDataSourceView(NoiDungCongViecQuanLyDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NoiDungCongViecQuanLyDataSource NoiDungCongViecQuanLyOwner
		{
			get { return Owner as NoiDungCongViecQuanLyDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NoiDungCongViecQuanLySelectMethod SelectMethod
		{
			get { return NoiDungCongViecQuanLyOwner.SelectMethod; }
			set { NoiDungCongViecQuanLyOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NoiDungCongViecQuanLyService NoiDungCongViecQuanLyProvider
		{
			get { return Provider as NoiDungCongViecQuanLyService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NoiDungCongViecQuanLy> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NoiDungCongViecQuanLy> results = null;
			NoiDungCongViecQuanLy item;
			count = 0;
			
			System.Int64 _id;
			System.Int32? _maCongViec_nullable;

			switch ( SelectMethod )
			{
				case NoiDungCongViecQuanLySelectMethod.Get:
					NoiDungCongViecQuanLyKey entityKey  = new NoiDungCongViecQuanLyKey();
					entityKey.Load(values);
					item = NoiDungCongViecQuanLyProvider.Get(entityKey);
					results = new TList<NoiDungCongViecQuanLy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NoiDungCongViecQuanLySelectMethod.GetAll:
                    results = NoiDungCongViecQuanLyProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NoiDungCongViecQuanLySelectMethod.GetPaged:
					results = NoiDungCongViecQuanLyProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NoiDungCongViecQuanLySelectMethod.Find:
					if ( FilterParameters != null )
						results = NoiDungCongViecQuanLyProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NoiDungCongViecQuanLyProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NoiDungCongViecQuanLySelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int64) EntityUtil.ChangeType(values["Id"], typeof(System.Int64)) : (long)0;
					item = NoiDungCongViecQuanLyProvider.GetById(_id);
					results = new TList<NoiDungCongViecQuanLy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case NoiDungCongViecQuanLySelectMethod.GetByMaCongViec:
					_maCongViec_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaCongViec"], typeof(System.Int32?));
					results = NoiDungCongViecQuanLyProvider.GetByMaCongViec(_maCongViec_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == NoiDungCongViecQuanLySelectMethod.Get || SelectMethod == NoiDungCongViecQuanLySelectMethod.GetById )
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
				NoiDungCongViecQuanLy entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NoiDungCongViecQuanLyProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<NoiDungCongViecQuanLy> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NoiDungCongViecQuanLyProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NoiDungCongViecQuanLyDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NoiDungCongViecQuanLyDataSource class.
	/// </summary>
	public class NoiDungCongViecQuanLyDataSourceDesigner : ProviderDataSourceDesigner<NoiDungCongViecQuanLy, NoiDungCongViecQuanLyKey>
	{
		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyDataSourceDesigner class.
		/// </summary>
		public NoiDungCongViecQuanLyDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NoiDungCongViecQuanLySelectMethod SelectMethod
		{
			get { return ((NoiDungCongViecQuanLyDataSource) DataSource).SelectMethod; }
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
				actions.Add(new NoiDungCongViecQuanLyDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NoiDungCongViecQuanLyDataSourceActionList

	/// <summary>
	/// Supports the NoiDungCongViecQuanLyDataSourceDesigner class.
	/// </summary>
	internal class NoiDungCongViecQuanLyDataSourceActionList : DesignerActionList
	{
		private NoiDungCongViecQuanLyDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NoiDungCongViecQuanLyDataSourceActionList(NoiDungCongViecQuanLyDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NoiDungCongViecQuanLySelectMethod SelectMethod
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

	#endregion NoiDungCongViecQuanLyDataSourceActionList
	
	#endregion NoiDungCongViecQuanLyDataSourceDesigner
	
	#region NoiDungCongViecQuanLySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NoiDungCongViecQuanLyDataSource.SelectMethod property.
	/// </summary>
	public enum NoiDungCongViecQuanLySelectMethod
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
		/// Represents the GetByMaCongViec method.
		/// </summary>
		GetByMaCongViec
	}
	
	#endregion NoiDungCongViecQuanLySelectMethod

	#region NoiDungCongViecQuanLyFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NoiDungCongViecQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NoiDungCongViecQuanLyFilter : SqlFilter<NoiDungCongViecQuanLyColumn>
	{
	}
	
	#endregion NoiDungCongViecQuanLyFilter

	#region NoiDungCongViecQuanLyExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NoiDungCongViecQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NoiDungCongViecQuanLyExpressionBuilder : SqlExpressionBuilder<NoiDungCongViecQuanLyColumn>
	{
	}
	
	#endregion NoiDungCongViecQuanLyExpressionBuilder	

	#region NoiDungCongViecQuanLyProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NoiDungCongViecQuanLyChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NoiDungCongViecQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NoiDungCongViecQuanLyProperty : ChildEntityProperty<NoiDungCongViecQuanLyChildEntityTypes>
	{
	}
	
	#endregion NoiDungCongViecQuanLyProperty
}

