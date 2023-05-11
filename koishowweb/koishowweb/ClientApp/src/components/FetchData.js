import React, { useEffect, useState } from "react";
import { LineChart, Line, CartesianGrid, XAxis, YAxis, Tooltip } from "recharts";

const FetchData = () => {
  const [ChartData1, setChartData1] = useState();
  const [ChartData2, setChartData2] = useState();
  const [ChartData3, setChartData3] = useState();
  const [ChartData4, setChartData4] = useState();
  const [ChartData5, setChartData5] = useState();
  const [ChartData6, setChartData6] = useState();
  const [ChartData7, setChartData7] = useState();
  const [ChartData8, setChartData8] = useState();

  useEffect(() => {
    if (ChartData1 == null) {
      GetFilterData();
    }
  });

  const GetFilterData = async () => {
    setChartData1([]);
    const response = await fetch("api/Temperature/28-3ce104573381/" + 100);
    const dataa = await response.json();
    let data = [];
    dataa.forEach((element) => {
      var dataelement = {
        name: element.dateTime,
        temp: element.value,
        pv: 2400,
        amt: 2400,
      };
      data.push(dataelement);
    });
    setChartData1(data);
  };

  return (
    <div className="d-flex flex-wrap">
      <LineChart
        width={600}
        height={300}
        data={ChartData1}
        margin={{ top: 5, right: 20, bottom: 5, left: 0 }}
      >
        <Line type="monotone" dataKey="temp" stroke="#8884d8" />
        <CartesianGrid stroke="#ccc" strokeDasharray="5 5" />
        <XAxis dataKey="name" />
        <YAxis />
        <Tooltip />
      </LineChart>
      <LineChart
        width={600}
        height={300}
        data={ChartData1}
        margin={{ top: 5, right: 20, bottom: 5, left: 0 }}
      >
        <Line type="monotone" dataKey="temp" stroke="#8884d8" />
        <CartesianGrid stroke="#ccc" strokeDasharray="5 5" />
        <XAxis dataKey="name" />
        <YAxis />
        <Tooltip />
      </LineChart>
      <LineChart
        width={600}
        height={300}
        data={ChartData1}
        margin={{ top: 5, right: 20, bottom: 5, left: 0 }}
      >
        <Line type="monotone" dataKey="temp" stroke="#8884d8" />
        <CartesianGrid stroke="#ccc" strokeDasharray="5 5" />
        <XAxis dataKey="name" />
        <YAxis />
        <Tooltip />
      </LineChart>
      <LineChart
        width={600}
        height={300}
        data={ChartData1}
        margin={{ top: 5, right: 20, bottom: 5, left: 0 }}
      >
        <Line type="monotone" dataKey="temp" stroke="#8884d8" />
        <CartesianGrid stroke="#ccc" strokeDasharray="5 5" />
        <XAxis dataKey="name" />
        <YAxis />
        <Tooltip />
      </LineChart>
      <LineChart
        width={600}
        height={300}
        data={ChartData1}
        margin={{ top: 5, right: 20, bottom: 5, left: 0 }}
      >
        <Line type="monotone" dataKey="temp" stroke="#8884d8" />
        <CartesianGrid stroke="#ccc" strokeDasharray="5 5" />
        <XAxis dataKey="name" />
        <YAxis />
        <Tooltip />
      </LineChart>
      <LineChart
        width={600}
        height={300}
        data={ChartData1}
        margin={{ top: 5, right: 20, bottom: 5, left: 0 }}
      >
        <Line type="monotone" dataKey="temp" stroke="#8884d8" />
        <CartesianGrid stroke="#ccc" strokeDasharray="5 5" />
        <XAxis dataKey="name" />
        <YAxis />
        <Tooltip />
      </LineChart>
      <LineChart
        width={600}
        height={300}
        data={ChartData1}
        margin={{ top: 5, right: 20, bottom: 5, left: 0 }}
      >
        <Line type="monotone" dataKey="temp" stroke="#8884d8" />
        <CartesianGrid stroke="#ccc" strokeDasharray="5 5" />
        <XAxis dataKey="name" />
        <YAxis />
        <Tooltip />
      </LineChart>
      <LineChart
        width={600}
        height={300}
        data={ChartData1}
        margin={{ top: 5, right: 20, bottom: 5, left: 0 }}
      >
        <Line type="monotone" dataKey="temp" stroke="#8884d8" />
        <CartesianGrid stroke="#ccc" strokeDasharray="5 5" />
        <XAxis dataKey="name" />
        <YAxis />
        <Tooltip />
      </LineChart>
    </div>
  );
};

export default FetchData;
