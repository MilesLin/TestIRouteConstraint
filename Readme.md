## 專案說明
這是一個預設範本的 MVC5 專案。 在 RouteConfig 新增一個自訂路由，自訂類別為 CmsUrlConstraint，該自訂路由會呼叫 async 的方法，結果造成死結。

## 進入死結點方式
網址輸入 http://localhost:52572/market

## 中斷點位置
CmsUrlConstraint.cs