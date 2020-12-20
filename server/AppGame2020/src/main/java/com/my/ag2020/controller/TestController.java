package com.my.ag2020.controller;

import java.util.ArrayList;
import java.util.List;
import org.apache.ibatis.annotations.Param;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import com.my.ag2020.service.TestService;
import com.my.ag2020.vo.CompatibilityVO;
import com.my.ag2020.vo.MonsterVO;
import com.my.ag2020.vo.StrongVO;
import com.my.ag2020.vo.TestVO;
import com.my.ag2020.vo.WeakMonsterVO;

@RestController
@RequestMapping("/test")
public class TestController {
	
	@Autowired
	private TestService service;
	
	@RequestMapping("/all")
	public List<TestVO> viewAll() {
		return service.viewAll();
	}
	
	@RequestMapping(value = "/monster/type/{type}", method = RequestMethod.GET)
	public List<MonsterVO> viewMonsterByType(@PathVariable String type) {
		return service.viewMonsterByType(type);
	}
	
	@RequestMapping(value = "/compatibility/weak/{weak}", method = RequestMethod.GET)
	public List<StrongVO> viewStrongTypeByType(@PathVariable String weak) {
		List<StrongVO> result = new ArrayList<StrongVO>();
		for (CompatibilityVO origin : service.viewStrongTypeByType(weak)) {
			StrongVO newOne = new StrongVO();
			newOne.setStrongVO(origin);
			result.add(newOne);
		}
		return result;
	}
	
	@RequestMapping(value = "/monster/name/{name}", method = RequestMethod.GET)
	public MonsterVO viewMonsterByName(@PathVariable String name) {
		return service.viewMonsterByName(name);
	}

}
