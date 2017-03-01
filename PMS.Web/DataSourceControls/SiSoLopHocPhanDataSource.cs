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
	/// Represents the DataRepository.SiSoLopHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SiSoLopHocPhanDataSourceDesigner))]
	public class SiSoLopHocPhanDataSource : ProviderDataSource<SiSoLopHocPhan, SiSoLopHocPhanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanDataSource class.
		/// </summary>
		public SiSoLopHocPhanDataSource() : base(new SiSoLopHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SiSoLopHocPhanDataSourceView used by the SiSoLopHocPhanDataSource.
		/// </summary>
		protected SiSoLopHocPhanDataSourceView SiSoLopHocPhanView
		{
			get { return ( View as SiSoLopHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SiSoLopHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public SiSoLopHocPhanSelectMethod SelectMethod
		{
			get
			{
				SiSoLopHocPhanSelectMethod selectMethod = SiSoLopHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SiSoLopHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SiSoLopHocPhanDataSourceView class that is to be
		/// used by the SiSoLopHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the SiSoLopHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<SiSoLopHocPhan, SiSoLopHocPhanKey> GetNewDataSourceView()
		{
			return new SiSoLopHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the SiSoLopHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SiSoLopHocPhanDataSourceView : ProviderDataSourceView<SiSoLopHocPhan, SiSoLopHocPhanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SiSoLopHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SiSoLopHocPhanDataSourceView(SiSoLopHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SiSoLopHocPhanDataSource SiSoLopHocPhanOwner
		{
			get { return Owner as SiSoLopHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SiSoLopHocPhanSelectMethod SelectMethod
		{
			get { return SiSoLopHocPhanOwner.SelectMethod; }
			set { SiSoLopHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SiSoLopHocPhanService SiSoLopHocPhanProvider
		{
			get { return Provider as SiSoLopHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SiSoLopHocPhan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SiSoLopHocPhan> results = null;
			SiSoLopHocPhan item;
			count = 0;
			
			System.String _scheduleStudyUnitId;

			switch ( SelectMethod )
			{
				case SiSoLopHocPhanSelectMethod.Get:
					SiSoLopHocPhanKey entityKey  = new SiSoLopHocPhanKey();
					entityKey.Load(values);
					item = SiSoLopHocPhanProvider.Get(entityKey);
					results = new TList<SiSoLopHocPhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SiSoLopHocPhanSelectMethod.GetAll:
                    results = SiSoLopHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SiSoLopHocPhanSelectMethod.GetPaged:
					results = SiSoLopHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SiSoLopHocPhanSelectMethod.Find:
					if ( FilterParameters != null )
						results = SiSoLopHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SiSoLopHocPhanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SiSoLopHocPhanSelectMethod.GetByScheduleStudyUnitId:
					_scheduleStudyUnitId = ( values["ScheduleStudyUnitId"] != null ) ? (System.String) EntityUtil.ChangeType(values["ScheduleStudyUnitId"], typeof(System.String)) : string.Empty;
					item = SiSoLopHocPhanProvider.GetByScheduleStudyUnitId(_scheduleStudyUnitId);
					results = new TList<SiSoLopHocPhan>();
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
			if ( SelectMethod == SiSoLopHocPhanSelectMethod.Get || SelectMethod == SiSoLopHocPhanSelectMethod.GetByScheduleStudyUnitId )
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
				SiSoLopHocPhan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SiSoLopHocPhanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SiSoLopHocPhan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SiSoLopHocPhanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SiSoLopHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SiSoLopHocPhanDataSource class.
	/// </summary>
	public class SiSoLopHocPhanDataSourceDesigner : ProviderDataSourceDesigner<SiSoLopHocPhan, SiSoLopHocPhanKey>
	{
		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanDataSourceDesigner class.
		/// </summary>
		public SiSoLopHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SiSoLopHocPhanSelectMethod SelectMethod
		{
			get { return ((SiSoLopHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SiSoLopHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SiSoLopHocPhanDataSourceActionList

	/// <summary>
	/// Supports the SiSoLopHocPhanDataSourceDesigner class.
	/// </summary>
	internal class SiSoLopHocPhanDataSourceActionList : DesignerActionList
	{
		private SiSoLopHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SiSoLopHocPhanDataSourceActionList(SiSoLopHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SiSoLopHocPhanSelectMethod SelectMethod
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

	#endregion SiSoLopHocPhanDataSourceActionList
	
	#endregion SiSoLopHocPhanDataSourceDesigner
	
	#region SiSoLopHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SiSoLopHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum SiSoLopHocPhanSelectMethod
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
		/// Represents the GetByScheduleStudyUnitId method.
		/// </summary>
		GetByScheduleStudyUnitId
	}
	
	#endregion SiSoLopHocPhanSelectMethod

	#region SiSoLopHocPhanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SiSoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SiSoLopHocPhanFilter : SqlFilter<SiSoLopHocPhanColumn>
	{
	}
	
	#endregion SiSoLopHocPhanFilter

	#region SiSoLopHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SiSoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SiSoLopHocPhanExpressionBuilder : SqlExpressionBuilder<SiSoLopHocPhanColumn>
	{
	}
	
	#endregion SiSoLopHocPhanExpressionBuilder	

	#region SiSoLopHocPhanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SiSoLopHocPhanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SiSoLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SiSoLopHocPhanProperty : ChildEntityProperty<SiSoLopHocPhanChildEntityTypes>
	{
	}
	
	#endregion SiSoLopHocPhanProperty
}

